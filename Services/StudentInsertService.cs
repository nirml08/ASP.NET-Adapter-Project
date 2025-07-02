using adapter.Model.apicaldata;
using adapter.Model.classmodel;

//using adapter.Model.classmodel;
using adapter.Repo;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace adapter.Services
{
    public class StudentInsertService
    {
        private readonly socketrepo _repository;

        public StudentInsertService(socketrepo sockrepo)
        {
            _repository = sockrepo;
        }


        public async Task<int> InsertApplication(ApplicationInfo entry)
        {
            var names = SplitName(entry.name);
            int campid = entry.registration.campus ?? 2;
            //int shift = campid==1?1:shiftmap.IsMorningShift(entry?.dept?.name);
            int shift = shiftmap.IsMorningShift1(entry?.dept?.name,campid);

            int appltype = entry.registration.program_info.name.ToLower() == "ug" ? 1 : 2;
            //String? PGMCODE = DepartmentMapper.GetDepartmentCode(entry.course.name) ?? "SOHI";
            String cname=  entry.course.name.Replace("&", "and").Trim();
            //int ? pgid = await _repository.GetProgrammeId(entry.course.name,campid);
            int? pgid = await _repository.GetProgrammeId(cname, campid, shift,appltype);
            int[] scores = {int.Parse(entry.score1?.Trim() ?? "0"), 
                            int.Parse(entry.score2?.Trim() ?? "0"), 
                            int.Parse(entry.score3?.Trim() ?? "0"),
                            int.Parse(entry.score4?.Trim() ?? "0"),
                            int.Parse(entry.score5?.Trim() ?? "0")};
            int hsc_total = scores.Sum();
            float hsc_percentage = (float)hsc_total / (scores.Length * 100) * 100;
            Console.WriteLine("Caste is " + entry.caste);
            String last_inst = "";
             if(appltype==1)
            {
                if (entry.institution12 is not null)
                    last_inst = entry.institution12.Length > 41 ? entry.institution12.Substring(0, 41) : entry.institution12;
                else
                    last_inst = "No Info";
            }
            else
            {
                last_inst = entry.lastinstname??"N/A";
            }

            var student = new StudentModel
            {
                FIRST_NAME = names.FirstName,
                LAST_NAME = names.LastName,
                FULL_NAME = entry.name,
                USER_CODE = "",//entry.id.ToString(),
                USER_TYPE = 17, //ADDED
                PROGRAMME = null, //pgid,
                GENDER = entry.gender == "female" ? 2 : 1,
                DOB = DateTime.TryParseExact(entry.dob, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dob) ? dob : (DateTime?)null,
                CASTE = entry.caste ?? "OTHERS",//entry?.caste?.Trim(),
                NATIONALITY = 85,
                RELIGION = ReligionIds.GetIdByReligion(entry?.religion_info.name),
                DEPARTMENT = null,//entry.dept?.id,
                BATCH = 8,
                MOBILE_NO = entry.phone,
                MAIL_ID = entry.email,
                AADHAR_NO = "999999999999",
                PHOTO_PATH = entry.pic_url ?? null, //entry.pic,
                ADDRESS = $"{entry.permanent_address}, {entry.per_pin}",
                BLOOD_GROUP_ID = BloodGroupIds.GetIdByGroup(entry.bloodgroup),
                IS_PHYSICALLY_CHALLENGED = entry.physically_challanged.Trim().ToLower() == "no" ? 0 : 1,
                FATHER_NAME = entry.fname.Trim(),
                MOTHER_NAME = entry.mname.Trim(),
                MOTHER_TONGUE = ReligionIds.GetTongueId(ReligionIds.FormatString(entry.mothertongue ?? "0")).ToString(),
                FR_MOBILE_NO = entry?.fcontact,
                MR_MOBILE_NO = entry?.mcontact,
                FR_OCCUPATION = entry?.foccupation,
                MR_OCCUPATION = entry?.moccupation,
                GUARDIAN_NAME = entry.gname?.Trim() ?? entry.fname?.Trim(),
                GUARDIAN_MOBILE_NO = entry.gcontact ?? entry.fcontact,
                IS_ACTIVE = 0,
                IS_DELETED = 0,
                IS_LEFT = 0,
                HSC_TOTAL = hsc_total,
                HSC_PERCENTAGE = hsc_percentage,
                PROGRAMME_LEVEL = appltype,//entry.registration.program_info.name.ToLower() == "ug" ? 1 : 2,
                ANNUAL_INCOME = entry.monthly_income,
                LAST_STUDIED_INSTITUTION = last_inst,//entry.institution12.Length > 41 ? entry.institution12.Substring(0, 41) : entry.institution12,
                CAMPUS_ID = entry.registration?.campus_info?.id,
                COMMUNITY = string.IsNullOrWhiteSpace(entry.caste) ? 7 : CasteMapper.GetCasteId(entry.caste.Trim()),
                REGISTER_NO = null,
                PLACE_OF_BIRTH = "INDIA",
                LAST_STUDIED_PLACE = last_inst,
                IS_ROMAN_CATHOLIC = 0
            };
            try
            {
                int user_id = await _repository.InsertStudent(student);
                student = null;
                return user_id;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            //return user_id;
        }

        private (string FirstName, string LastName) SplitName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return ("", "");

            var parts = fullName.Trim().Split(' ', 2);
            return (
                parts.Length > 0 ? parts[0] : "",
                parts.Length > 1 ? parts[1] : ""
            );
        }


        /*public async Task<int?> GetRecieveId(ApplicationInfo entry)
        {
            var names = SplitName(entry.name);
            var student = new StudentModel
            {
                FIRST_NAME = names.FirstName,
                LAST_NAME = names.LastName,
                MOBILE_NO = entry.phone,
                
            };
            return await _repository.GetRecieveId(student);
        } */


        // for marks entry


        public async Task InsertUserAccountService(ApplicationInfo entry)
        {
            var uac = new AUserAccount
            {
                Username = entry?.email?.Trim() ?? entry.application_id,
                Password = PHash.CreateSHA256("123456"),//pwdhash("123456"),
                Name = entry.name.Trim() ?? entry.application_id.ToString(),
                LastLogin = null,
                UserId = entry.recieve_id,
                Role = "17",
                Photo = null,// entry.pic_url,
                UserType = 17,
                CampusId = entry.registration?.campus ?? 2,
                IsDeleted = 0,
                IsActive = 1,
                USER_UNIQUE_ID = null
            };

            try
            {
                await _repository.InsertLoginAccount(uac); // actual DB insert
            }
            catch (Exception ex)
            {
                Console.WriteLine($"InsertLogin failed for {entry.fname}: {ex.Message}");

            }


        }

        public async Task InsertMarksFromApplication(ApplicationInfo entry)
        {
            if (entry == null || entry.user_id == null)
                return;

            //int studentId = application.user_id ?? 0;
            //int campusId = application.registration?.campus_info?.id ?? 0;

            List<MarkRecordsModel> marks = new();
            if (entry.registration.program_info.name.ToLower() == "ug")
            {

                for (int i = 1; i <= 5; i++)
                {
                    string subjectKey = $"sub{i}";
                    string scoreKey = $"score{i}";

                    var subject = entry.GetType().GetProperty(subjectKey)?.GetValue(entry)?.ToString();
                    var scoreVal = entry.GetType().GetProperty(scoreKey)?.GetValue(entry)?.ToString();

                    if (!string.IsNullOrWhiteSpace(subject) && int.TryParse(scoreVal, out int score))
                    {
                        var mark = new MarkRecordsModel
                        {
                            RECEIVE_STUID = entry.recieve_id,
                            SUBJECT_ID = 0,
                            SUBJECT = subject,
                            MAX_MARK = 100,
                            MARK = score,
                            M_PASS = "2025",
                            IS_DELETED = 0,
                            ACADEMIC_YEAR = 2025,
                            SEMESTER_ID = null,
                            SGPA_OR_PERCENTAGE = null,
                            NO_OF_ATTEMPTS = 1,
                            EDUCATION_BOARD_ID = 0,
                            EDUCATION_BOARD = "No Info",
                            CAMPUS_ID = entry.registration?.campus_info?.id
                        };

                        marks.Add(mark);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    string sgpaKey = $"sgpa{i}";
                    var sgpaVal = entry.GetType().GetProperty(sgpaKey)?.GetValue(entry)?.ToString();

                    if (double.TryParse(sgpaVal, out double sgpa) && sgpa > 0)
                    {
                        var sgpaRecord = new MarkRecordsModel
                        {
                            RECEIVE_STUID = entry.recieve_id,
                            SUBJECT_ID = 0,
                            SUBJECT = "",//$"SGPA SEM {i}", // or just $"SGPA {i}"
                            MAX_MARK = 10,
                            MARK = 0,//null,
                            M_PASS = "2025",
                            IS_DELETED = 0,
                            ACADEMIC_YEAR = 2025,
                            SEMESTER_ID = i,
                            SGPA_OR_PERCENTAGE = sgpa,
                            NO_OF_ATTEMPTS = 1,
                            EDUCATION_BOARD_ID = 0,
                            EDUCATION_BOARD = "No Info",
                            CAMPUS_ID = entry.registration?.campus_info?.id
                        };

                        marks.Add(sgpaRecord);
                    }
                }
            }



                foreach (var mark in marks)
                {
                    try
                    {
                        await _repository.InsertMarks(mark); // actual DB insert
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("$InsertMarks failed for {entry.fname}: {ex.Message}");

                    }
                }
        }


        public async Task InsertStudentAddress(ApplicationInfo entry)
        {
            if (entry == null || entry.user_id == null)
                return;

            //int studentId = application.user_id ?? 0;
            //int campusId = application.registration?.campus_info?.id ?? 0;
            var stdadr = new AStudentAddress
            {
                ADDRESS_ID = null,
                STUDENT_ID = entry.recieve_id,
                C_DOOR_DETAIL = (entry.permanent_address.Length > 249 ? entry.permanent_address.Substring(0, 249) : entry.permanent_address)??"No Info",
                C_STREET = (entry.permanent_address.Length > 249 ? entry.permanent_address.Substring(0, 249) : entry.permanent_address)??"No Info",
                C_VILLAGE_AREA = (entry.permanent_address.Length > 249 ? entry.permanent_address.Substring(0, 249) : entry.permanent_address)??"No Info",
                C_POST_PLACE_TOWN = "No Info",
                C_TALUK = "No Info",
                C_CITY = "No Info",
                C_DISTRICT = "No Info",
                C_PINCODE = entry.per_pin.ToString(),
                C_PHONENO = entry.phone,
                C_STATE = "No Info",
                C_POLICE_STATION = "No Info",
                C_COUNTRY = CountryIds.GetIdByCountryName(entry.registration?.country_info?.name),

                P_DOOR_DETAIL = (entry.permanent_address.Length > 249 ? entry.permanent_address.Substring(0, 249) : entry.permanent_address) ?? "No Info",
                P_STREET = (entry.permanent_address.Length > 249 ? entry.permanent_address.Substring(0, 249) : entry.permanent_address) ?? "No Info",
                P_VILLAGE_AREA = (entry.permanent_address.Length > 249 ? entry.permanent_address.Substring(0, 249) : entry.permanent_address) ?? "No Info",
                P_POST_PLACE_TOWN = "No Info",
                P_TALUK = "No Info",
                P_CITY = "No Info",
                P_DISTRICT = "No Info",
                P_PINCODE = entry.per_pin.ToString(),
                P_PHONENO = entry.phone,
                P_STATE = "No Info",
                P_POLICE_STATION = "No Info",
                P_COUNTRY = CountryIds.GetIdByCountryName(entry.registration?.country_info?.name),

                ADDRESS = (entry.permanent_address.Length > 249 ? entry.permanent_address.Substring(0, 249) : entry.permanent_address) ?? "No Info",
                IS_DELETED = 0

            };
            try
            {
                await _repository.InsertStuAddress(stdadr);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"StudentAdrdress failed for {entry.fname}: {ex.Message}");

            }


        }

        public async Task InsertUploadedFiles(ApplicationInfo entry)
        {
            if (entry == null || entry.recieve_id==null)
                return;
            List<string> urls = [entry?.certificate_x, entry?.certificate_xii, entry?.adhaar_url, entry?.UgDoc];
            int loopi= entry.registration.program_info.name.ToLower() == "ug" ? 3 : 4;
            for (int i = 1; i <= loopi; i++)
            {
                
                var file = new AAdmUploadedFiles
                {
                    //FILE_ID = Guid.NewGuid().ToString(),                        // Assuming a unique identifier
                    //FILE_PATH = entry.pic,                                     // Assuming `entry.pic` is the uploaded file path NEED ACTUAL FILE PATHS
                    FILE_TYPE_ID = FileTypeIds.GetIdByFileType(i),                //1=10 pass cert,2=12 pass cert,3=adhaar
                    RECEIVE_ID = entry.recieve_id,
                    FILE_PATH = urls[i-1],
                    IS_DELETED =0,
                    IS_ACTIVE = 0,
                    ACADEMIC_YEAR = 2025,                                    // Or derive from entry
                    CAMPUS_ID = entry.registration?.campus_info?.id,
                    
                };

                try
                {
                    await _repository.InsertFilesUploaded(file);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }





        public async Task InsertAdmIssuedApplication(ApplicationInfo entry)
        {
            if (entry == null || entry.registration == null || entry.registration.id == null)
                return;
            int isPaid = entry.payment_gateway_status?.ToLower() == "success" ? 1 : 0;
            int campid = entry.registration.campus ?? 2;
            String cname = entry.course.name.Replace("&", "and").Trim();
            int shift =  shiftmap.IsMorningShift1(entry?.dept?.name,campid);//campid == 1 ? 1 :shiftmap.IsMorningShift(entry?.dept?.name);
            //String? depcode = await _repository.GetProgrammeCode(entry.course.name,campid);
            //Console.WriteLine(entry.course.name+" "+DepartmentMapper.GetDepartmentCode(entry.course.name));
            int appltype = entry.registration.program_info.name.ToLower() == "ug" ? 1 : 2;
            String? depcode = await _repository.GetProgrammeCode(cname, campid, shift,appltype);
            int? PGRID = await _repository.GetProgrammeId(cname, campid, shift,appltype);
            string pay_status = entry.payment_info is null ? (entry.payment_gateway_status is null?"":entry.payment_gateway_status) : entry.payment_info.status.ToLower();

            var issuedApp = new AdmIssuedApplication
            {
                //ISSUED_ID = application.registration.id.Value,
                APPLICATION_NO = entry.application_id,
                DEPARTMENT_CODE = depcode,//DepartmentMapper.GetDepartmentCode(entry.course.name),//DepartmentMapper.GetDepartmentCode(entry.course.name), 
                RECEIVE_ID = entry.recieve_id ?? 0,
                PROGRAMME_GROUP_ID = PGRID,//application.registration.program_info?.id ?? 0,
                STATUS = ConvertApplicationStatus(entry.registration.application_filled,pay_status,entry.interview_msg??"no"),//ConvertApplicationFilled(entry.registration.application_filled, entry.payment_info?.status ?? "Failed"),
                SELECTION_TYPE = 0, // Placeholder, no mapping provided
                IS_ACTIVE = 0, // Set active by default or based on business logic
                IS_DELETED = 0,
                ACADEMIC_YEAR = 2025, // You can make this dynamic
                IS_PAID = isPaid,//entry.payment_gateway_status?.ToLower() == "success" ? 1 : 0,
                //PAYMENT_MODE = !string.IsNullOrEmpty(entry.payment_gateway_id) ? 6 : 1,
                PAYMENT_MODE = isPaid == 1
                    ? string.IsNullOrEmpty(entry.payment_gateway_id) ? 1 : 6 : (int?)null,

                RAZORPAY_ID = entry.payment_gateway_id,
                OLD_PROGRAMME_GROUP_ID = null, // Placeholder, no mapping provided
                PRIORITY_ORDER = 0, // Placeholder, no mapping provided
                CAMPUS_ID = entry.registration.campus,
                //string createdAtStr = entry.created_at, // ensure this is a string
                APPLY_DATE = entry.registration.created_at//DateTime.Parse(entry.created_at.ToString(), null, System.Globalization.DateTimeStyles.RoundtripKind)



            };
            Console.WriteLine(issuedApp.PROGRAMME_GROUP_ID);

            try
            {
                await _repository.InsertAdmIssuedApplication(issuedApp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"IssuedApplication failed for {entry.fname}: {ex.Message}");

            }

        }

        private int ConvertApplicationFilled(string status,string pstatus)
        {
            
            //if (string.IsNullOrWhiteSpace(status)) return 1;
            if (string.IsNullOrWhiteSpace(pstatus)) return 1;
            bool Registered = true;
            bool Inprogress = pstatus.ToLower() == "success" ? true : false;
            bool Submitted=status.ToLower()=="yes"?true : false;

            if (Inprogress && Submitted && Registered) return 2;    //submitted
            if (Inprogress && !Submitted && Registered) return 9;   //inprogress
            if (Inprogress ==false && Registered) return 1;  //registered
            return 1;

                /*return status.ToLower() switch
                {
                    "Yes" => 3,
                    "No" => 2,
                    _ => 2
                };*/
        }
        private int ConvertApplicationStatus(string applicationFilled, string paymentStatus, string interviewMessage)
        {
            if ((interviewMessage?.ToLower()) == "yes")
            {
                return 3;
            }
            else
            {

                if ((applicationFilled?.ToLower() == "yes") && (paymentStatus?.ToLower()) == "success")
                {
                    return 2;
                }

                if ((applicationFilled?.ToLower() == "yes") && (paymentStatus?.ToLower()) != "success")
                {
                    return 1;
                }
            }

            return 1;
        }

        public async Task InsertAdmSelectionProcess(ApplicationInfo entry)
        {
            if (entry == null || entry.registration == null || entry.registration.id == null)
                return;
            //int isPaid = entry.payment_gateway_status?.ToLower() == "success" ? 1 : 0;
            int campid = entry.registration.campus ?? 2;
            String cname = entry.course.name.Replace("&", "and").Trim();
            int shift = shiftmap.IsMorningShift1(entry?.dept?.name, campid);
            int appltype = entry.registration.program_info.name.ToLower() == "ug" ? 1 : 2;
            String? depcode = await _repository.GetProgrammeCode(cname, campid, shift, appltype);
            int? PGRID = await _repository.GetProgrammeId(cname, campid, shift, appltype);
            string pay_status = entry.payment_info is null ? (entry.payment_gateway_status is null ? "" : entry.payment_gateway_status) : entry.payment_info.status.ToLower();
            int ispaid = entry.payment_info is null ? (entry.payment_gateway_status is null ? 0 : entry.payment_gateway_status?.ToLower() == "success" ? 1 : 0) : entry.payment_info.status.ToLower() == "success" ? 1 : 0;
            var selectrow = new SelectionProcess
            {
                Application_No=entry.application_id,
                Application_Type_Id=appltype,
                Programme_Id=PGRID,
                Selection_Date= new DateTime(2025, 6, 28, 15, 30, 40),//entry.updated_at,
                Selection_Type =1,
                Selection_Cycle=1,
                Entrance_Mark=0,
                Total_Cut_Off_Mark=0,
                Total_Secured=0,
                Max_Total=500,
                Selected_By=7258,
                Verified_By=0, // GET flow info
                Is_Deleted=0,
                Is_Fee_Paid=ispaid,
                Receive_Id=entry.recieve_id??0,
                Is_Verified=0,
                Is_Transfered=0,
                Is_Canceled=0,
                Is_Sports_Quota=0,
                Campus_Id=campid,
                Interview_Date_Time=entry.updated_at.ToString()
            };
            try
            {
                await _repository.InsertAdmSelectionProcess(selectrow);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Selection Process failed for {entry.fname}: {ex.Message}");

            }
        }






        //public async Task<String> InsertForderInfo25(ApplicationInfo entry)
        public async Task InsertForderInfo25(ApplicationInfo entry)
        {
            int campid = entry.registration.campus ?? 2;
            int shift = shiftmap.IsMorningShift1(entry?.dept?.name,campid);
            String cname = entry.course.name.Replace("&", "and").Trim();
            int appltype = entry.registration.program_info.name.ToLower() == "ug" ? 1 : 2;
            int? pgid = await _repository.GetProgrammeId(cname, campid, shift, appltype);
            int receipt = 0;
            var amount_paid = 0;
            if(entry.payment_info is null)
            {
                amount_paid = 0;
            }
            else
            {
                amount_paid = entry.payment_info.status.ToLower() == "success" ? 1 : 0;
            }
                var order = new ForderInfo25
                {
                    //EB_ORDER_ID = 0, // Assuming this is auto-incremented or unused in insert
                    ID = entry.payment_info is null?entry.application_id:entry.payment_info.txnid,//CreateOrder(),
                    ENTITY = "order",
                    AMOUNT = entry.captured_amount,
                    AMOUNT_PAID = amount_paid,//entry.payment_gateway_status==null ? 0 : (entry.payment_gateway_status?.ToLower() == "success" ? 1 : 0),//entry.payment_info?.status.ToLower()== "success" ? 1:0,
                    AMOUNT_DUE = 750,//entry.payment_info?.amount,
                    CURRENCY = "INR",
                    RECEIPT = "", // No value provided
                    OFFER_ID = "", // No value provided
                    STATUS = entry.payment_info is null?entry.payment_gateway_status ?? "Not Paid":entry.payment_info.status,//"created",
                    ATTEMPTS = 0,
                    CREATED_AT = entry.created_at ?? DateTime.Now,//DateTime.Parse(entry.created_at.ToString()), // Or DateTime.TryParse
                    UDF1 = entry.recieve_id.ToString(), // No value provided
                    UDF2 = "3",  //note 2 is for the semester admission fees
                    UDF3 = (entry.registration.campus == 2 ? 35 : 36).ToString(), // No value provided
                    UDF4 = "", // No value provided
                    UDF5 = "1",
                    UDF6 = pgid.ToString(), // No value provided  //programme_group_id
                    UDF7 = "2025",
                    IS_ACTIVE = 0,
                    IS_DELETED = 0,
                    PAY_URL = "", // No value provided
                    IS_PROCESSED = 0
                };
            try
            {
                await _repository.InsertForderInfo25(order);
                //return order.ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Order Creation failed for {entry.fname}: {ex.Message}");
                //return "0";

            }
        }
        public string CreateOrder()
        {
            string orderId = "order_" + Guid.NewGuid().ToString();
            return orderId; // e.g., "order_a1b2c3d4e5f647839a0b1c2d3e4f5g6h"
        }


        

        public async Task InsertAFebTfResponse25(ApplicationInfo entry)
        {
            var tfResponse = new AFebTfResponse25
            {
                // EB_TRANSFER_ID is assumed to be auto-incremented and not manually set
                ORDER_ID = entry.payment_info.txnid,//entry.od_id, // Make sure this field exists in ApplicationInfo
                AMOUNT = entry.payment_info.amount,
                //EMAIL = "payments@salesiancollege.net",
                //PHONE = "",

                STATUS = null,
                easepayid = entry.payment_info.easepayid,
                STR_RESPONSE = "",

                //RESPONSE = "",

                CREATED_AT = entry.payment_info?.updated_at ?? DateTime.Now,//DateTime.TryParse(entry.payment_info.updated_at, out var createdAt)
                                                                            //? createdAt : DateTime.Now,

                SETTLEMENT_DATE = entry.payment_info?.updated_at ?? DateTime.Now,//DateTime.TryParse(entry.updated_at.ToString(), out var updatedAt)
                                                                                 //? updatedAt : (DateTime?)null,

                UDF1 = entry.recieve_id.ToString(),
                UDF2 = "3",
                UDF3 = (entry.registration.campus == 2 ? 35 : 36).ToString(),
                UDF4 = "",
                //UDF5 = "",
                //UDF6 = "",

                IS_ACTIVE = 0,
                IS_DELETED = 0
            };

            try
            {
                await _repository.InsertAFebTfResponse25(tfResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ebTFRESPONSE failed for {entry.fname}: {ex.Message}");
                //return "0";

            }

            //await _repository.InsertAFebTfResponse25(tfResponse);
        }



        public async Task<int> InsertFeeTransactionAsync(ApplicationInfo entry)
        {
            int isPaid = entry.payment_info.status?.ToLower() == "success" ? 1 : 0;
            int transactionId = 0;
            int rcpt = await Areceipt.get_receipt(2,_repository);
            var transaction = new FeeTranx
            {
                // ID is likely auto-incremented, so not set
                STUDENT_ID = entry.recieve_id.ToString(),
                FREQUENCY = entry.registration.campus == 2 ? 35 : 36,//entry.registration.campus==2?35:36,
                CLASS = 0,
                PAYMENT_DATE = entry.payment_info?.created_at ?? DateTime.Now,//entry.payment_info != null?entry.payment_info.created_at : DateTime.Now,//DateTime.Parse(entry.payment_info.created_at.ToString()),  ///need exact payment time
                RECEIPT_NO = rcpt.ToString(), // need more details related to generation
                PAYMENT_MODE = isPaid == 1
                               ? (string.IsNullOrEmpty(entry.payment_gateway_id) ? 1 : 6)
                               : 0,

                DD_CHEQUE_NO = null,
                COLLECTED = (double)(entry.captured_amount ?? 0),
                DISCOUNT = null, // since "" not valid for double
                DEDUCT_STUDENT_ACCOUNT = null,
                RECEIPT_NARRATION = null,
                USERNAME = entry.recieve_id.ToString(),
                ACADEMIC_YEAR = 2025,
                IS_DELETED = 0,
                IS_AMOUNT_COLLECTED = isPaid==1?1:0,
                IS_ACCOUNTANT_COLLECTED = 0,
                IS_ADVANCE = 0,
                UPLOAD_FLAG = 0,
                IS_DOWNLOADED = 0,
                IS_UPDATED = 0,
                DOWNLOAD_TIME = null,
                FEE_TRANSACTION_COUNTER = 0,
                FEE_TRANSACTION_BANK = 0,
                TEMP_ID = 0,
                EXCESS_AMT = 0,
                F_TRANSACTION_ID = 0,
                FREQUENCY_TO = entry.registration.campus == 2 ? 35 : 36,
                CHALLAN_NO = null,
                PayUResponse_Id = null,
                RAZORPAY_ID = null,
                RECEIPT_NO1 = null,
                RECEIPT_NO2 = null,
                EASEPAYID = entry?.payment_gateway_id
            };
            try
            {
                transactionId = await _repository.InsertFeeTransaction(transaction);
                return transactionId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FeeTransaction failed for {entry.fname}: {ex.Message}");
                return 0;

            }
            //int transactionId=await _repository.InsertFeeTransaction(transaction);
            //return transactionId;
        }




        public async Task InsertFeeCollectionAsync(ApplicationInfo entry)
        {
            int campid = entry.registration.campus??2;
            String cname = entry.course.name.Replace("&", "and").Trim();
            //int? pgid = await _repository.GetProgrammeId(cname, campid);
            int shift = shiftmap.IsMorningShift1(entry?.dept?.name,campid);//campid == 1 ? 1 : shiftmap.IsMorningShift(entry?.dept?.name);


            int ApplicationTypeId = entry.registration.program_info.name == "UG" ? 1 : 2;//entry.registration.application_type;
            
            int fid = entry.registration.campus == 2 ? 35 : 36;
            int? HeadId = await _repository.GetFeeMainHeadIdAsync(campid,ApplicationTypeId,shift, fid);
            var collection = new FeeCollection
            {
                // COLLECTION_ID is assumed to be auto-generated by the DB
                TRANSACTION_ID = entry.Transaction_id,
                HEAD = 5,
                PAID_AMOUNT = 750,
                IS_DOWNLOADED = 0,
                IS_UPDATED = 0,
                DOWNLOAD_TIME = null,
                FREQUENCY = (uint)(campid== 2 ? 35:36),
                RECEIPT_NO = "",
                SORT_ORDER = 0,
                IS_DELETED = 0,
                TEMP_ID = 0,
                FEE_MAIN_HEAD_ID = HeadId,
                SETTLEMENT_DATE = null,
                B_SETTLEMENT_DATE = null,
                FEE_RAZORPAY_TRANSFER_ID = null,
                FEE_RAZORPAY_SETTLEMENT_ID = null
            };

            try
            {
                await _repository.InsertFeeCollectionAsync(collection);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FeeCollection failed for {entry.fname}: {ex.Message}");
                //return "0";

            }
            //await _repository.InsertFeeCollectionAsync(collection);
        }



        public async Task InsertFeeStudentAccountAsync(ApplicationInfo entry)
        {
            int campid = entry.registration.campus ?? 2;
            int fid = entry.registration.campus == 2 ? 35 : 36;

            int shift =  shiftmap.IsMorningShift1(entry?.dept?.name,campid);//campid == 1 ? 1 :shiftmap.IsMorningShift(entry?.dept?.name);
            int ApplicationTypeId = entry.registration.program_info.name == "UG" ? 1 : 2;// entry.registration.application_type;
            String? cname = entry.course.name.Replace("&", "and").Trim();
            int appltype = entry.registration.program_info.name.ToLower() == "ug" ? 1 : 2;
            int? PGRID = await _repository.GetProgrammeId(cname, campid, shift, appltype); //DepartmentMapper.GetDepartmentCode(entry.course.name)??"SOHI";
            int? HeadId = await _repository.GetFeeMainHeadIdAsync(campid, ApplicationTypeId, shift,fid);
            

            int? fstid = await _repository.GetFeeStructureId(PGRID,fid,campid);



            var credit_account = new FeeStdAccount
            {
                // STUDENT_AC_ID is auto-incremented; do not assign
                STUDENT_ID = entry.recieve_id ?? 0,
                ACADEMIC_YEAR = 2025,
                FREQUENCY_ID = fid,//entry.registration.campus == 2 ? 35 : 36,
                HEAD = 5,
                CREDIT = 750,
                DEBIT = null,
                TRANSACTION_DATE = null,
                DISCOUNT_ID = null,
                STU_DISCOUNT_ID = null,
                IS_DELETED = 0,
                TRANSACTION_ID = null,
                BANK = 0,
                IS_REFUND = 0,
                SPONSOR_ID = 0,
                //F_STUDENT_AC_ID is auto-incremented
                FINE_DATE = null,
                IS_CANCELLED_HEAD = 0,
                FEE_MAIN_HEAD_ID = HeadId,       // You can set this if needed (e.g., from HeadId)
                INSTALLMENT_ID = null,
                REASON = null,
                FEE_STRUCTURE_ID = fstid
            };
            int generatedId = await _repository.InsertFeeStudentAccountCreditAsync(credit_account);

            var debit_account = new FeeStdAccount
            {

                F_STUDENT_AC_ID=generatedId,// STUDENT_AC_ID is auto-incremented; do not assign
                STUDENT_ID = entry.recieve_id ?? 0,
                ACADEMIC_YEAR = 2025,
                FREQUENCY_ID = fid,//entry.registration.campus == 2 ? 35 : 36,
                HEAD = 5,
                CREDIT =null,
                DEBIT = 750,
                TRANSACTION_DATE = null,
                DISCOUNT_ID = null,
                STU_DISCOUNT_ID = null,
                IS_DELETED = 0,
                TRANSACTION_ID = entry.Transaction_id,
                BANK = 0,
                IS_REFUND = 0,
                SPONSOR_ID = 0,
                //F_STUDENT_AC_ID = generatedId,
                FINE_DATE = null,
                IS_CANCELLED_HEAD = 0,
                FEE_MAIN_HEAD_ID = HeadId,       // You can set this if needed (e.g., from HeadId)
                INSTALLMENT_ID = null,
                REASON = null,
                FEE_STRUCTURE_ID = fstid
            };
            //if (entry.payment_gateway_status?.ToLower() == "success")
            if (entry.payment_info != null && entry.payment_info.status.ToLower() == "success")
            {
                await _repository.InsertFeeStudentAccountDebitAsync(debit_account);
            }

        }


    }
}
