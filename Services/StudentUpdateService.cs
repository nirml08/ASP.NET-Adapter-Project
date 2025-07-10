using adapter.Model.apicaldata;


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
    public class StudentUpdateService
    {
        private readonly updaterepo _repository;

        public StudentUpdateService(updaterepo sockrepo)
        {
            _repository = sockrepo;
        }
        public async Task<int> GetReceiveId(ApplicationInfo entry)
        {
            int receiveId = await _repository.GetRecieveId(entry.application_id);
            return 0;
        }

        public async Task UpdateAdmIssuedApplication(ApplicationInfo entry)
        {
            if (entry == null || entry.registration == null || entry.registration.id == null)
                return;
            int isPaid = entry.payment_gateway_status?.ToLower() == "success" ? 1 : 0;
            string pay_status = entry.payment_info is null ? (entry.payment_gateway_status is null?"":entry.payment_gateway_status) : entry.payment_info.status.ToLower();

            var issuedApp = new AdmIssuedApplication
            {
                //ISSUED_ID = application.registration.id.Value,
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

            };
          
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"IssuedApplication failed for {entry.fname}: {ex.Message}");

            }

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

        public async Task UpdateAdmSelectionProcess(ApplicationInfo entry)
        {
            
           
            try
            {

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
            int shift = shiftmap.IsMorningShift1(entry?.dept?.name, campid);
            String cname = entry.course.name.Replace("&", "and").Trim();
            int appltype = entry.registration.program_info.name.ToLower() == "ug" ? 1 : 2;
            int? pgid = await _repository.GetProgrammeId(cname, campid, shift, appltype);
            int receipt = 0;
            var amount_paid = 0;
            amount_paid =(entry.payment_info?.status?.ToLower() == "success" || (entry.payment_gateway_status ?? "NA") == "success")? 1 : 0;
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
                    STATUS = entry.payment_info is null?(entry.payment_gateway_status ?? "Not Paid"):entry.payment_info.status,//"created",
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




            int generatedId = 0; //get geneated id

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
            //if ( entry.payment_info is null ? (entry.payment_gateway_status is null?"":entry.payment_gateway_status) : entry.payment_info.status.ToLower())
            if (entry.payment_info?.status?.ToLower() == "success" || (entry.payment_gateway_status ?? "NA") == "success")
                {
                    await _repository.InsertFeeStudentAccountDebitAsync(debit_account);
                }

        }


    }
}
