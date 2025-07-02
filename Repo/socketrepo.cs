using adapter.Model.classmodel;
using adapter.Dbpool;
using System.Threading.RateLimiting;
using adapter.Model.apicaldata;
using Humanizer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace adapter.Repo
{
    public class socketrepo
    {
        public readonly dbcontext _dbcontext;
        public socketrepo(dbcontext dbcon)
        {
            _dbcontext = dbcon;
        }
        public async Task<IEnumerable<StudentClass>> FetchSelectedStudent(String roll)
        {
            const string ql = "Select USER_ID as STUDENT_ID,FIRST_NAME, LAST_NAME,GENDER,DOB, USER_TYPE,DEPARTMENT, PROGRAMME as PROGRAMME_GROUP_ID, " +
                "CLASS_ID, BATCH,MOBILE_NO, MAIL_ID,DOJ,CAMPUS_ID, PHOTO_PATH,ROLL_NO,IS_ACTIVE, IS_DELETED,IS_LEFT  " +
                "from campus_360_uat.user_details where roll_no=@roll";
            //string rll = roll;

            //ql = ql.Replace("@roll",rll);

            return await _dbcontext.Getall<StudentClass>(ql, new { roll });
        }

        public async Task<IEnumerable<CourseRoot>> FetchRealtedCourse(int uid)
        {
            const string ql = "Select COURSE_TITLE,COURSE_CODE,SEMESTER_ID from campus_360_uat.cp_course_root where course_root_id in (select course_id from campus_360_uat.stu_course_info where student_id=@uid and academic_year=2024 and is_deleted!=1);";
            //string rll = roll;

            //ql = ql.Replace("@roll",rll);

            return await _dbcontext.Getall<CourseRoot>(ql, new { uid });
        }



        public async Task<int?> GetRecieveId(StudentModel student)
        {
            const string query = @"Select user_id from campus_360_uat.user_details where first_name=@FIRST_NAME and LAST_NAME=@LASTNAME AND MOBILE_NO=@MOBILE_NO LIMIT 1;";
            //const string query = 
            var result = await _dbcontext.Getall<int>(query, new
            {
                student.FIRST_NAME,
                student.LAST_NAME,
                student.MOBILE_NO
            });

            return result.FirstOrDefault();
        }



        //public async Task<int?> GetProgrammeId(String PGMCODE,int campid,int shift, int appltype)
        public async Task<int?> GetProgrammeId(String PGMCODE1, int campid, int shift, int appltype)
        {
            string PGMCODE = "";
            if(PGMCODE1=="Data Science")
            {
                PGMCODE = "BCA - with specialization in Full Stack Development/ Artificial Intelligence and Machine Learning/ Data Science";
            }
            else if (PGMCODE1 == "Finance")
            {
                //PGMCODE = "BCA - with specialization in Full Stack Development/ Artificial Intelligence and Machine Learning/ Data Science";
                PGMCODE = "BBA - with specialization in Finance / Marketing / Human Resources";
            }
            else
            {
                PGMCODE = PGMCODE1;
            }
            const string query = @"SELECT programme_group_id FROM campus_360_uat.CP_PROGRAMME_GROUP AS CPG INNER JOIN (SELECT * FROM campus_360_uat.CP_PROGRAMME WHERE  campus_id=@campid and is_deleted!=1) AS CP  
                             ON CPG.PROGRAMME_ID=CP.PROGRAMME_ID WHERE cp.PROGRAMME_DESCRIPTION like CONCAT('%', @PGMCODE, '%') and CPG.CAMPUS_ID=@CAMPID and CPG.is_deleted!=1 and shift=@shift and CPG.APPTYPE_ID=@appltype;";


            const string query1 = @"SELECT programme_group_id 
                           FROM CP_PROGRAMME_GROUP AS CPG 
                           INNER JOIN (SELECT * FROM CP_PROGRAMME WHERE campus_id=@campid AND is_deleted!=1) AS CP  
                           ON CPG.PROGRAMME_ID = CP.PROGRAMME_ID 
                           WHERE cp.PROGRAMME_DESCRIPTION LIKE CONCAT('%', @PGMCODE, '%') 
                           AND CPG.CAMPUS_ID = @campid 
                           AND CPG.is_deleted != 1 
                           AND shift = @shift;";

            // For debugging only — do not use string interpolation to execute SQL!
            string debugQuery = query1
                .Replace("@campid", campid.ToString())
                .Replace("@PGMCODE", $"'{PGMCODE}'")
                .Replace("@shift", shift.ToString());
            Console.WriteLine(debugQuery);

            //select PROGRAMME_ID from cp_programme where programme_CODE=@PGMCODE and campus_id=@campid and is_deleted!=1 LIMIT 1;

            //return await _dbcontext.Executeall<int?>(query, new { campid, PGMCODE,shift });
            var result = await _dbcontext.Executeall<int?>(query, new { campid, PGMCODE, shift,appltype });
            if (result == null)
            {
                Console.WriteLine($"No PGID found for \n {query}");
                // handle "no result" case
            }
            return result;
        }
        public async Task<String?> GetProgrammeCode(String PGMCODE, int campid, int shift, int appltype)
        {
            if (PGMCODE == "Data Science")
            {
                PGMCODE = "BCA - with specialization in Full Stack Development/ Artificial Intelligence and Machine Learning/ Data Science";
            }
            if (PGMCODE == "Finance")
            {
                //PGMCODE = "BCA - with specialization in Full Stack Development/ Artificial Intelligence and Machine Learning/ Data Science";
                PGMCODE = "BBA - with specialization in Finance / Marketing / Human Resources";
            }

            const string query = @"SELECT CPg.PROGRAMME_GROUP_CODE FROM campus_360_uat.CP_PROGRAMME_GROUP AS CPG INNER JOIN (SELECT * FROM campus_360_uat.CP_PROGRAMME WHERE  campus_id=@campid and is_deleted!=1) AS CP  
                             ON CPG.PROGRAMME_ID=CP.PROGRAMME_ID WHERE cp.PROGRAMME_DESCRIPTION like CONCAT('%', @PGMCODE, '%') and CPG.CAMPUS_ID=@CAMPID and CPG.is_deleted!=1 and shift=@shift and CPG.APPTYPE_ID=@appltype;";
            //select PROGRAMME_ID from cp_programme where programme_CODE=@PGMCODE and campus_id=@campid and is_deleted!=1 LIMIT 1;
            /*string debugQuery = $@"
SELECT CPG.PROGRAMME_GROUP_CODE 
FROM campus_360_uat.CP_PROGRAMME_GROUP AS CPG 
INNER JOIN (
    SELECT * FROM campus_360_uat.CP_PROGRAMME 
    WHERE campus_id='{campid}' AND is_deleted != 1
) AS CP ON CPG.PROGRAMME_ID = CP.PROGRAMME_ID 
WHERE cp.PROGRAMME_DESCRIPTION LIKE CONCAT('%', '{PGMCODE}', '%') 
  AND CPG.CAMPUS_ID = '{campid}' 
  AND CPG.is_deleted != 1 
  AND shift = '{shift}' 
  AND CPG.APPTYPE_ID = '{appltype}';"; */
            //Console.WriteLine(debugQuery);


            return await _dbcontext.Executes<String?>(query, new { campid, PGMCODE,shift,appltype });
        }

        public async Task<int> InsertStudent(StudentModel student)
        {
            /*const string query = @"
                                INSERT INTO campus_360_uat.user_details 
                                (USER_CODE,FIRST_NAME, LAST_NAME, GENDER, DOB, USER_TYPE, COMMUNITY, NATIONALITY, RELIGION, DEPARTMENT, 
                                 PROGRAMME, CLASS_ID, BATCH, CATEGORY, MOBILE_NO, MAIL_ID, AADHAR_NO, PHOTO_PATH, ADDRESS, 
                                 ROLL_NO, DOJ, CAMPUS_ID, IS_ACTIVE, IS_DELETED, IS_LEFT, BLOOD_GROUP_ID, IS_PHYSICALLY_CHALLENGED,CASTE,
                                MOTHER_TONGUE,MOTHER_NAME,FATHER_NAME,GUARDIAN_MOBILE_NO,GUARDIAN_NAME,MR_OCCUPATION,FR_OCCUPATION,MR_MOBILE_NO,FR_MOBILE_NO)
                                VALUES 
                                (@USER_CODE,@FIRST_NAME, @LAST_NAME, @GENDER, @DOB, @USER_TYPE, @COMMUNITY, @NATIONALITY, @RELIGION, @DEPARTMENT, 
                                 @PROGRAMME, @CLASS_ID, @BATCH, @CATEGORY, @MOBILE_NO, @MAIL_ID, @AADHAR_NO, @PHOTO_PATH, @ADDRESS, 
                                 @ROLL_NO, @DOJ, @CAMPUS_ID, @IS_ACTIVE, @IS_DELETED, @IS_LEFT, @BLOOD_GROUP_ID, @IS_PHYSICALLY_CHALLENGED,@CASTE,
                                  @MOTHER_TONGUE,@MOTHER_NAME,@FATHER_NAME,@GUARDIAN_MOBILE_NO,@GUARDIAN_NAME,@MR_OCCUPATION,@FR_OCCUPATION,@MR_MOBILE_NO,@FR_MOBILE_NO);

            

                                    SELECT LAST_INSERT_ID();";*/
            const string query = @"
                                INSERT INTO campus_360_uat.user_details 
                                (USER_CODE,FIRST_NAME, LAST_NAME, FULL_NAME, GENDER, DOB, USER_TYPE, COMMUNITY, COMMUNITY_NUMBER,
                                 MEDIUM_OF_INSTRUCTION, NATIONALITY, CASTE, RELIGION, DEPARTMENT, PROGRAMME, CLASS_ID, BATCH, CATEGORY,
                                 BARCODE, MOBILE_NO, MAIL_ID, AADHAR_NO, PAN_NO, RFID, GSUITE_MAIL_ID, GSUITE_PASSWORD, DOJ, DOL,
                                 CAMPUS_ID, PHOTO_PATH, ADDRESS, REGISTER_NO, ROLL_NO, BIOMETRIC_NUMBER, RESIDENCE_ID, HEIGHT, WEIGHT,
                                 GOAL, STRENGTH, WEAKNESS, ROLE_MODEL, FAMILY_TYPE_ID, FATHER_NAME, MOTHER_NAME, IS_PERMANANT, IS_ACTIVE,
                                 IS_DELETED, IS_LEFT, SIGNATURE, COLLEGE_ROLL_NO, ADMISSION_NO, HSC_NO, HSC_TOTAL, HSC_PERCENTAGE,
                                 HSC_TC_DATE, TC_SERIAL_NO, TC_APPLIED_DATE, TC_GIVEN_DATE, FINE_NAME, ADMITTED_CLASS, ADMISSION_DATE,
                                 PROGRAMME_LEVEL, HSS_GROUP_ID, IS_SUBMITTED, TOTAL_CUT_OFF_MARK, BLOOD_GROUP_ID, IS_PHYSICALLY_CHALLENGED,
                                 IS_HOSPITALIZED, HOSPITALIZED_REASON, IS_SERIOUS_ILL, ILL_COUNT, IS_HAVE_ALERGY, DISABILITY_TYPE_ID,
                                 ALERGY_DESCRITION, PLACE_OF_BIRTH, MOTHER_TONGUE, FR_MOBILE_NO, MR_MOBILE_NO, FR_OCCUPATION, MR_OCCUPATION,
                                 GUARDIAN_OCCUPATION, FATHER_QUALIFICATION, MOTHER_QUALIFICATION, GUARDIAN_QUALIFICATION, FATHER_ANNUAL_INCOME,
                                 MOTHER_ANNUAL_INCOME, GUARDIAN_ANNUAL_INCOME, NO_OF_BROTHERS, NO_OF_SISTERS, GUARDIAN_NAME, GUARDIAN_MOBILE_NO,
                                 HSC_MAX_MARK, UNIVERSITY_ID, UNIVERSITY_REGISTER_NO, LAST_STUDIED_INSTITUTION, LAST_STUDIED_PLACE,
                                 IS_FULL_TIME, IS_PART_TIME, ANNUAL_INCOME, IS_ROMAN_CATHOLIC, IDENTIFICATION_MARK1, IDENTIFICATION_MARK2,
                                 CERTIFICATE1, CERTIFICATE2, CERTIFICATE3, CERTIFICATE_DATE, STATUS, LASTSEEN, ISAVAILABLE, LOGINSTATUS,
                                 GRADUATION_YEAR, REMARKS)
                                VALUES 
                                (@USER_CODE, @FIRST_NAME, @LAST_NAME, @FULL_NAME, @GENDER, @DOB, @USER_TYPE, @COMMUNITY, @COMMUNITY_NUMBER,
                                 @MEDIUM_OF_INSTRUCTION, @NATIONALITY, @CASTE, @RELIGION, @DEPARTMENT, @PROGRAMME, @CLASS_ID, @BATCH, @CATEGORY,
                                 @BARCODE, @MOBILE_NO, @MAIL_ID, @AADHAR_NO, @PAN_NO, @RFID, @GSUITE_MAIL_ID, @GSUITE_PASSWORD, @DOJ, @DOL,
                                 @CAMPUS_ID, @PHOTO_PATH, @ADDRESS, @REGISTER_NO, @ROLL_NO, @BIOMETRIC_NUMBER, @RESIDENCE_ID, @HEIGHT, @WEIGHT,
                                 @GOAL, @STRENGTH, @WEAKNESS, @ROLE_MODEL, @FAMILY_TYPE_ID, @FATHER_NAME, @MOTHER_NAME, @IS_PERMANANT, @IS_ACTIVE,
                                 @IS_DELETED, @IS_LEFT, @SIGNATURE, @COLLEGE_ROLL_NO, @ADMISSION_NO, @HSC_NO, @HSC_TOTAL, @HSC_PERCENTAGE,
                                 @HSC_TC_DATE, @TC_SERIAL_NO, @TC_APPLIED_DATE, @TC_GIVEN_DATE, @FINE_NAME, @ADMITTED_CLASS, @ADMISSION_DATE,
                                 @PROGRAMME_LEVEL, @HSS_GROUP_ID, @IS_SUBMITTED, @TOTAL_CUT_OFF_MARK, @BLOOD_GROUP_ID, @IS_PHYSICALLY_CHALLENGED,
                                 @IS_HOSPITALIZED, @HOSPITALIZED_REASON, @IS_SERIOUS_ILL, @ILL_COUNT, @IS_HAVE_ALERGY, @DISABILITY_TYPE_ID,
                                 @ALERGY_DESCRITION, @PLACE_OF_BIRTH, @MOTHER_TONGUE, @FR_MOBILE_NO, @MR_MOBILE_NO, @FR_OCCUPATION, @MR_OCCUPATION,
                                 @GUARDIAN_OCCUPATION, @FATHER_QUALIFICATION, @MOTHER_QUALIFICATION, @GUARDIAN_QUALIFICATION, @FATHER_ANNUAL_INCOME,
                                 @MOTHER_ANNUAL_INCOME, @GUARDIAN_ANNUAL_INCOME, @NO_OF_BROTHERS, @NO_OF_SISTERS, @GUARDIAN_NAME, @GUARDIAN_MOBILE_NO,
                                 @HSC_MAX_MARK, @UNIVERSITY_ID, @UNIVERSITY_REGISTER_NO, @LAST_STUDIED_INSTITUTION, @LAST_STUDIED_PLACE,
                                 @IS_FULL_TIME, @IS_PART_TIME, @ANNUAL_INCOME, @IS_ROMAN_CATHOLIC, @IDENTIFICATION_MARK1, @IDENTIFICATION_MARK2,
                                 @CERTIFICATE1, @CERTIFICATE2, @CERTIFICATE3, @CERTIFICATE_DATE, @STATUS, @LASTSEEN, @ISAVAILABLE, @LOGINSTATUS,
                                 @GRADUATION_YEAR, @REMARKS);
                                    SELECT LAST_INSERT_ID();";


            int USER_ID = await _dbcontext.Executeall<int>(query, new
            {
                student.USER_CODE,
                student.FIRST_NAME,
                student.LAST_NAME,
                student.FULL_NAME,
                student.GENDER,
                student.DOB,
                student.USER_TYPE,
                student.COMMUNITY,
                student.COMMUNITY_NUMBER,
                student.MEDIUM_OF_INSTRUCTION,
                student.NATIONALITY,
                student.CASTE,
                student.RELIGION,
                student.DEPARTMENT,
                student.PROGRAMME,
                student.CLASS_ID,
                student.BATCH,
                student.CATEGORY,
                student.BARCODE,
                student.MOBILE_NO,
                student.MAIL_ID,
                student.AADHAR_NO,
                student.PAN_NO,
                student.RFID,
                student.GSUITE_MAIL_ID,
                student.GSUITE_PASSWORD,
                student.DOJ,
                student.DOL,
                student.CAMPUS_ID,
                student.PHOTO_PATH,
                student.ADDRESS,
                student.REGISTER_NO,
                student.ROLL_NO,
                student.BIOMETRIC_NUMBER,
                student.RESIDENCE_ID,
                student.HEIGHT,
                student.WEIGHT,
                student.GOAL,
                student.STRENGTH,
                student.WEAKNESS,
                student.ROLE_MODEL,
                student.FAMILY_TYPE_ID,
                student.FATHER_NAME,
                student.MOTHER_NAME,
                student.IS_PERMANANT,
                student.IS_ACTIVE,
                student.IS_DELETED,
                student.IS_LEFT,
                student.SIGNATURE,
                student.COLLEGE_ROLL_NO,
                student.ADMISSION_NO,
                student.HSC_NO,
                student.HSC_TOTAL,
                student.HSC_PERCENTAGE,
                student.HSC_TC_DATE,
                student.TC_SERIAL_NO,
                student.TC_APPLIED_DATE,
                student.TC_GIVEN_DATE,
                student.FINE_NAME,
                student.ADMITTED_CLASS,
                student.ADMISSION_DATE,
                student.PROGRAMME_LEVEL,
                student.HSS_GROUP_ID,
                student.IS_SUBMITTED,
                student.TOTAL_CUT_OFF_MARK,
                student.BLOOD_GROUP_ID,
                student.IS_PHYSICALLY_CHALLENGED,
                student.IS_HOSPITALIZED,
                student.HOSPITALIZED_REASON,
                student.IS_SERIOUS_ILL,
                student.ILL_COUNT,
                student.IS_HAVE_ALERGY,
                student.DISABILITY_TYPE_ID,
                student.ALERGY_DESCRITION,
                student.PLACE_OF_BIRTH,
                student.MOTHER_TONGUE,
                student.FR_MOBILE_NO,
                student.MR_MOBILE_NO,
                student.FR_OCCUPATION,
                student.MR_OCCUPATION,
                student.GUARDIAN_OCCUPATION,
                student.FATHER_QUALIFICATION,
                student.MOTHER_QUALIFICATION,
                student.GUARDIAN_QUALIFICATION,
                student.FATHER_ANNUAL_INCOME,
                student.MOTHER_ANNUAL_INCOME,
                student.GUARDIAN_ANNUAL_INCOME,
                student.NO_OF_BROTHERS,
                student.NO_OF_SISTERS,
                student.GUARDIAN_NAME,
                student.GUARDIAN_MOBILE_NO,
                student.HSC_MAX_MARK,
                student.UNIVERSITY_ID,
                student.UNIVERSITY_REGISTER_NO,
                student.LAST_STUDIED_INSTITUTION,
                student.LAST_STUDIED_PLACE,
                student.IS_FULL_TIME,
                student.IS_PART_TIME,
                student.ANNUAL_INCOME,
                student.IS_ROMAN_CATHOLIC,
                student.IDENTIFICATION_MARK1,
                student.IDENTIFICATION_MARK2,
                student.CERTIFICATE1,
                student.CERTIFICATE2,
                student.CERTIFICATE3,
                student.CERTIFICATE_DATE,
                student.STATUS,
                student.LASTSEEN,
                student.ISAVAILABLE,
                student.LOGINSTATUS,
                student.GRADUATION_YEAR,
                student.REMARKS
            });


            /*int USER_ID = await _dbcontext.Executeall<int>(query, new
            {
               
                student.USER_CODE,
                student.FIRST_NAME,
                student.LAST_NAME,
                student.FULL_NAME,
                student.GENDER,
                student.DOB,
                student.USER_TYPE,
                student.COMMUNITY,
                student.NATIONALITY,
                student.RELIGION,
                //student.DEPARTMENT,
                //student.PROGRAMME,
                student.CLASS_ID,
                student.BATCH,
                student.CATEGORY,
                student.MOBILE_NO,
                student.MAIL_ID,
                student.AADHAR_NO,
                student.PHOTO_PATH,
                student.ADDRESS,
                student.ROLL_NO,
                student.DOJ,
                student.CAMPUS_ID,
                student.IS_ACTIVE,
                student.IS_DELETED,
                student.IS_LEFT,
                student.BLOOD_GROUP_ID,
                student.IS_PHYSICALLY_CHALLENGED,
                student.CASTE,
                student.MOTHER_TONGUE,
                student.MOTHER_NAME,
                student.FATHER_NAME,
                student.GUARDIAN_MOBILE_NO,
                student.GUARDIAN_NAME,
                student.MR_OCCUPATION,
                student.FR_OCCUPATION,
                student.MR_MOBILE_NO,
                student.FR_MOBILE_NO,
                student.HSC_TOTAL,
                student.HSC_PERCENTAGE,
                student.ANNUAL_INCOME,
                student.LAST_STUDIED_INSTITUTION,
                student.PROGRAMME_LEVEL,
                student.COMMUNITY_NUMBER

            });*/
            return USER_ID;
        }


        public async Task InsertLoginAccount(AUserAccount uac)
        {
            const string query = @"
    INSERT INTO campus_360_uat.user_account
    (USERNAME, PASSWORD, NAME,LAST_LOGIN, USER_ID, ROLE, USER_TYPE, PHOTO, CAMPUS_ID, IS_DELETED, IS_ACTIVE, USER_UNIQUE_ID)
    VALUES 
    (@Username, @Password, @Name,@LastLogin, @UserId, @Role, @UserType, @Photo, @CampusId, @IsDeleted, @IsActive, @USER_UNIQUE_ID);";

            await _dbcontext.ExecuteAsync(query, new
            {
              uac.Username,
              uac.Password,
              uac.Name,
              uac.LastLogin,
              uac.UserId,
              uac.Role,
              uac.UserType,
              uac.Photo,
              uac.CampusId,
              uac.IsDeleted,
              uac.IsActive,
              uac.USER_UNIQUE_ID
            });


        }

        public async Task<int> InsertMarks(MarkRecordsModel mark)
        {
            const string query = @"
                                    INSERT INTO campus_360_uat.adm_stu_submarks 
                                    (RECEIVE_STUID, SUBJECT_ID, SUBJECT, MAX_MARK, MARK, M_PASS, IS_DELETED, ACADEMIC_YEAR, 
                                     SEMESTER_ID, SGPA_OR_PERCENTAGE, NO_OF_ATTEMPTS, EDUCATION_BOARD_ID, EDUCATION_BOARD, CAMPUS_ID)
                                    VALUES 
                                    (@RECEIVE_STUID, @SUBJECT_ID, @SUBJECT, @MAX_MARK, @MARK, @M_PASS, @IS_DELETED, @ACADEMIC_YEAR, 
                                     @SEMESTER_ID, @SGPA_OR_PERCENTAGE, @NO_OF_ATTEMPTS, @EDUCATION_BOARD_ID, @EDUCATION_BOARD, @CAMPUS_ID);";

            return await _dbcontext.Execute(query, new
            {
                //mark.MARK_ID,
                mark.RECEIVE_STUID,
                mark.SUBJECT_ID,
                mark.SUBJECT,
                mark.MAX_MARK,
                mark.MARK,
                mark.M_PASS,
                mark.IS_DELETED,
                mark.ACADEMIC_YEAR,
                mark.SEMESTER_ID,
                mark.SGPA_OR_PERCENTAGE,
                mark.NO_OF_ATTEMPTS,
                mark.EDUCATION_BOARD_ID,
                mark.EDUCATION_BOARD,
                mark.CAMPUS_ID
            });
        }

        public async Task<int> InsertStuAddress(AStudentAddress addr)
        {
            const string query = @"
                INSERT INTO campus_360_uat.stu_address 
                (STUDENT_ID, 
                 C_DOOR_DETAIL, C_STREET, C_VILLAGE_AREA, C_POST_PLACE_TOWN, C_TALUK, C_CITY, C_DISTRICT, C_PINCODE, C_PHONENO, C_STATE, C_POLICE_STATION, C_COUNTRY,
                 P_DOOR_DETAIL, P_STREET, P_VILLAGE_AREA, P_POST_PLACE_TOWN, P_TALUK, P_CITY, P_DISTRICT, P_PINCODE, P_PHONENO, P_STATE, P_POLICE_STATION, P_COUNTRY,
                 ADDRESS, IS_DELETED)
                VALUES 
                (@STUDENT_ID, 
                 @C_DOOR_DETAIL, @C_STREET, @C_VILLAGE_AREA, @C_POST_PLACE_TOWN, @C_TALUK, @C_CITY, @C_DISTRICT, @C_PINCODE, @C_PHONENO, @C_STATE, @C_POLICE_STATION, @C_COUNTRY,
                 @P_DOOR_DETAIL, @P_STREET, @P_VILLAGE_AREA, @P_POST_PLACE_TOWN, @P_TALUK, @P_CITY, @P_DISTRICT, @P_PINCODE, @P_PHONENO, @P_STATE, @P_POLICE_STATION, @P_COUNTRY,
                 @ADDRESS, @IS_DELETED);";

            return await _dbcontext.Execute(query, new
            {
                //addr.ADDRESS_ID,
                addr.STUDENT_ID,

                addr.C_DOOR_DETAIL,
                addr.C_STREET,
                addr.C_VILLAGE_AREA,
                addr.C_POST_PLACE_TOWN,
                addr.C_TALUK,
                addr.C_CITY,
                addr.C_DISTRICT,
                addr.C_PINCODE,
                addr.C_PHONENO,
                addr.C_STATE,
                addr.C_POLICE_STATION,
                addr.C_COUNTRY,

                addr.P_DOOR_DETAIL,
                addr.P_STREET,
                addr.P_VILLAGE_AREA,
                addr.P_POST_PLACE_TOWN,
                addr.P_TALUK,
                addr.P_CITY,
                addr.P_DISTRICT,
                addr.P_PINCODE,
                addr.P_PHONENO,
                addr.P_STATE,
                addr.P_POLICE_STATION,
                addr.P_COUNTRY,

                addr.ADDRESS,
                addr.IS_DELETED
            });
        }


        public async Task<int> InsertFilesUploaded(AAdmUploadedFiles file)
        {
            const string query = @"
                            INSERT INTO campus_360_uat.adm_uploaded_files 
                            (RECEIVE_ID, FILE_TYPE_ID, FILE_PATH, IS_DELETED, IS_ACTIVE, ACADEMIC_YEAR, CAMPUS_ID)
                            VALUES 
                            (@RECEIVE_ID, @FILE_TYPE_ID, @FILE_PATH, @IS_DELETED, @IS_ACTIVE, @ACADEMIC_YEAR, @CAMPUS_ID);";

            return await _dbcontext.Execute(query, new
            {
                file.RECEIVE_ID,
                file.FILE_TYPE_ID,
                file.FILE_PATH,
                file.IS_DELETED,
                file.IS_ACTIVE,
                file.ACADEMIC_YEAR,
                file.CAMPUS_ID
            });
        }


        //public async Task<int> InsertAdmIssuedApplication(AdmIssuedApplication appdata)
        public async Task InsertAdmIssuedApplication(AdmIssuedApplication appdata)
        {
            //await _dbcontext.ExecuteAdmAsync("SELECT 1", null);
            using (var transaction = _dbcontext.Connection.BeginTransaction())
            {
                const string query = @"
                                    INSERT INTO campus_360_uat.adm_issued_applications
                                    (
                                        APPLICATION_NO,DEPARTMENT_CODE, RECEIVE_ID,PROGRAMME_GROUP_ID, STATUS, SELECTION_TYPE,
                                        IS_ACTIVE, IS_DELETED, ACADEMIC_YEAR, IS_PAID,
                                        PAYMENT_MODE, RAZORPAY_ID, OLD_PROGRAMME_GROUP_ID,
                                        PRIORITY_ORDER, CAMPUS_ID, APPLY_DATE
                                    )
                                    VALUES
                                    (
                                        @APPLICATION_NO,@DEPARTMENT_CODE, @RECEIVE_ID,@PROGRAMME_GROUP_ID, @STATUS, @SELECTION_TYPE,
                                        @IS_ACTIVE, @IS_DELETED, @ACADEMIC_YEAR, @IS_PAID,
                                        @PAYMENT_MODE, @RAZORPAY_ID, @OLD_PROGRAMME_GROUP_ID,
                                        @PRIORITY_ORDER, @CAMPUS_ID, @APPLY_DATE
                                    );  
                                     SELECT LAST_INSERT_ID();";

                var displayQuery = $@"
                                    INSERT INTO campus_360_uat.adm_issued_applications (
                                        APPLICATION_NO, DEPARTMENT_CODE, RECEIVE_ID, PROGRAMME_GROUP_ID, STATUS, SELECTION_TYPE,
                                        IS_ACTIVE, IS_DELETED, ACADEMIC_YEAR, IS_PAID,
                                        PAYMENT_MODE, RAZORPAY_ID, OLD_PROGRAMME_GROUP_ID,
                                        PRIORITY_ORDER, CAMPUS_ID, APPLY_DATE
                                    )
                                    VALUES (
                                        '{appdata.APPLICATION_NO}', '{appdata.DEPARTMENT_CODE}', '{appdata.RECEIVE_ID}', '{appdata.PROGRAMME_GROUP_ID}', '{appdata.STATUS}', '{appdata.SELECTION_TYPE}',
                                        {appdata.IS_ACTIVE}, {appdata.IS_DELETED}, '{appdata.ACADEMIC_YEAR}', {appdata.IS_PAID},
                                        '{appdata.PAYMENT_MODE}', '{appdata.RAZORPAY_ID}', '{appdata.OLD_PROGRAMME_GROUP_ID}',
                                        {appdata.PRIORITY_ORDER}, '{appdata.CAMPUS_ID}', '{appdata.APPLY_DATE:yyyy-MM-dd HH:mm:ss}'
                                    );
                                    ";

                //Console.WriteLine(displayQuery);


                //var inserted_id= await _dbcontext.Execute(query, new
                var inserted_id = await _dbcontext.ExecuteAdmScalarAsync<long>(query, new
                {
                    appdata.DEPARTMENT_CODE,
                    appdata.APPLICATION_NO,
                    appdata.RECEIVE_ID,
                    appdata.PROGRAMME_GROUP_ID,
                    appdata.STATUS,
                    appdata.SELECTION_TYPE,
                    appdata.IS_ACTIVE,
                    appdata.IS_DELETED,
                    appdata.ACADEMIC_YEAR,
                    appdata.IS_PAID,
                    appdata.PAYMENT_MODE,
                    appdata.RAZORPAY_ID,
                    appdata.OLD_PROGRAMME_GROUP_ID,
                    appdata.PRIORITY_ORDER,
                    appdata.CAMPUS_ID,
                    appdata.APPLY_DATE
                },transaction);

                const string updateQuery = @"
            UPDATE campus_360_uat.adm_issued_applications
            SET APPLICATION_NO = @NewApplicationNo
            WHERE ISSUED_ID = @InsertedId;";

                await _dbcontext.ExecuteAdmAsync(updateQuery, new
                {
                    NewApplicationNo = appdata.APPLICATION_NO,
                    InsertedId = inserted_id
                },transaction);
                transaction.Commit();
            }
        }



        public async Task InsertAdmSelectionProcess(SelectionProcess selectdata)
        {
            const string query = @"INSERT INTO campus_360_uat.adm_selection_process_2025 (
                                APPLICATION_NO,APPLICATION_TYPE_ID,PROGRAMME_ID,SELECTION_DATE,SELECTION_TYPE,SELECTION_CYCLE,
                                ENTRANCE_MARK,TOTAL_CUT_OFF_MARK,TOTAL_SECURED,MAX_TOTAL,SELECTED_BY,VERIFIED_BY,IS_DELETED,IS_FEE_PAID,RECEIVE_ID,
                                IS_VERIFIED,IS_TRANSFERED,IS_CANCELED,IS_SPORTS_QUOTA,CAMPUS_ID,INTERVIEW_DATE_TIME
                            ) VALUES (
                                @APPLICATION_NO,@APPLICATION_TYPE_ID,@PROGRAMME_ID,@SELECTION_DATE,@SELECTION_TYPE,@SELECTION_CYCLE,@ENTRANCE_MARK,
                                @TOTAL_CUT_OFF_MARK,@TOTAL_SECURED,@MAX_TOTAL,@SELECTED_BY,@VERIFIED_BY,@IS_DELETED,@IS_FEE_PAID,@RECEIVE_ID,
                                @IS_VERIFIED,@IS_TRANSFERED,@IS_CANCELED,@IS_SPORTS_QUOTA,@CAMPUS_ID,@INTERVIEW_DATE_TIME
                            );";
            await _dbcontext.ExecuteAsync(query, new
            {
                selectdata.Application_No,
                selectdata.Application_Type_Id,
                selectdata.Programme_Id,
                selectdata.Selection_Date,
                selectdata.Selection_Type,
                selectdata.Selection_Cycle,
                selectdata.Entrance_Mark,
                selectdata.Total_Cut_Off_Mark,
                selectdata.Total_Secured,
                selectdata.Max_Total,
                selectdata.Selected_By,
                selectdata.Verified_By,
                selectdata.Is_Deleted,
                selectdata.Is_Fee_Paid,
                selectdata.Receive_Id,
                selectdata.Is_Verified,
                selectdata.Is_Transfered,
                selectdata.Is_Canceled,
                selectdata.Is_Sports_Quota,
                selectdata.Campus_Id,
                selectdata.Interview_Date_Time
            });

        }






        public async Task InsertForderInfo25(ForderInfo25 order)
        {
            const string query = @"
                                INSERT INTO campus_360_uat.fee_eb_order_info_2025 (
                                     ID, ENTITY, AMOUNT, AMOUNT_PAID, AMOUNT_DUE,
                                    CURRENCY, RECEIPT, OFFER_ID, STATUS, ATTEMPTS, CREATED_AT,
                                    UDF1, UDF2, UDF3, UDF4, UDF5, UDF6, UDF7,
                                    IS_ACTIVE, IS_DELETED, PAY_URL,IS_PROCESSED
                                )
                                VALUES (
                                    @ID, @ENTITY, @AMOUNT, @AMOUNT_PAID, @AMOUNT_DUE,
                                    @CURRENCY, @RECEIPT, @OFFER_ID, @STATUS, @ATTEMPTS, @CREATED_AT,
                                    @UDF1, @UDF2, @UDF3, @UDF4, @UDF5, @UDF6, @UDF7,
                                    @IS_ACTIVE, @IS_DELETED, @PAY_URL,@IS_PROCESSED
                                );";
             await _dbcontext.Execute(query,new
                        {
                            //order.EB_ORDER_ID,
                            order.ID,
                            order.ENTITY,
                            order.AMOUNT,
                            order.AMOUNT_PAID,
                            order.AMOUNT_DUE,
                            order.CURRENCY,
                            order.RECEIPT,
                            order.OFFER_ID,
                            order.STATUS,
                            order.ATTEMPTS,
                            order.CREATED_AT,
                            order.UDF1,
                            order.UDF2,
                            order.UDF3,
                            order.UDF4,
                            order.UDF5,
                            order.UDF6,
                            order.UDF7,
                            order.IS_ACTIVE,
                            order.IS_DELETED,
                            order.PAY_URL,
                            order.IS_PROCESSED
                        });
        }


        public async Task InsertAFebTfResponse25(AFebTfResponse25 response)
        {
            const string query = @"
                            INSERT INTO campus_360_uat.fee_eb_tfresponse_2025 (
                                ORDER_ID, AMOUNT, EMAIL, PHONE, STATUS, easepayid, STR_RESPONSE, RESPONSE,
                                CREATED_AT, SETTLEMENT_DATE,
                                UDF1, UDF2, UDF3, UDF4, UDF5, UDF6,
                                IS_ACTIVE, IS_DELETED
                            )
                            VALUES (
                                @ORDER_ID, @AMOUNT, @EMAIL, @PHONE, @STATUS, @easepayid, @STR_RESPONSE, @RESPONSE,
                                @CREATED_AT, @SETTLEMENT_DATE,
                                @UDF1, @UDF2, @UDF3, @UDF4, @UDF5, @UDF6,
                                @IS_ACTIVE, @IS_DELETED
                            );";

            await _dbcontext.Execute(query, new
            {
                response.ORDER_ID,
                response.AMOUNT,
                response.EMAIL,
                response.PHONE,
                response.STATUS,
                response.easepayid,
                response.STR_RESPONSE,
                response.RESPONSE,
                response.CREATED_AT,
                response.SETTLEMENT_DATE,
                response.UDF1,
                response.UDF2,
                response.UDF3,
                response.UDF4,
                response.UDF5,
                response.UDF6,
                response.IS_ACTIVE,
                response.IS_DELETED
            });
        }


        public async Task<int> InsertFeeTransaction(FeeTranx transaction)
        {
            const string query = @"
                                    INSERT INTO campus_360_uat.fee_transaction (
                                        STUDENT_ID, FREQUENCY, CLASS, PAYMENT_DATE, RECEIPT_NO, PAYMENT_MODE,
                                        DD_CHEQUE_NO, COLLECTED, DISCOUNT, DEDUCT_STUDENT_ACCOUNT, RECEIPT_NARRATION,
                                        USERNAME, ACADEMIC_YEAR, IS_DELETED, IS_AMOUNT_COLLECTED, IS_ACCOUNTANT_COLLECTED,
                                        IS_ADVANCE, UPLOAD_FLAG, IS_DOWNLOADED, IS_UPDATED, DOWNLOAD_TIME,
                                        FEE_TRANSACTION_COUNTER, FEE_TRANSACTION_BANK, TEMP_ID, EXCESS_AMT,
                                        F_TRANSACTION_ID, FREQUENCY_TO, CHALLAN_NO, PayUResponse_Id, RAZORPAY_ID,
                                        RECEIPT_NO1, RECEIPT_NO2, EASEPAYID
                                    )
                                    VALUES (
                                        @STUDENT_ID, @FREQUENCY, @CLASS, @PAYMENT_DATE, @RECEIPT_NO, @PAYMENT_MODE,
                                        @DD_CHEQUE_NO, @COLLECTED, @DISCOUNT, @DEDUCT_STUDENT_ACCOUNT, @RECEIPT_NARRATION,
                                        @USERNAME, @ACADEMIC_YEAR, @IS_DELETED, @IS_AMOUNT_COLLECTED, @IS_ACCOUNTANT_COLLECTED,
                                        @IS_ADVANCE, @UPLOAD_FLAG, @IS_DOWNLOADED, @IS_UPDATED, @DOWNLOAD_TIME,
                                        @FEE_TRANSACTION_COUNTER, @FEE_TRANSACTION_BANK, @TEMP_ID, @EXCESS_AMT,
                                        @F_TRANSACTION_ID, @FREQUENCY_TO, @CHALLAN_NO, @PayUResponse_Id, @RAZORPAY_ID,
                                        @RECEIPT_NO1, @RECEIPT_NO2, @EASEPAYID
                                    );
                                    SELECT LAST_INSERT_ID();
                                ";

            return await _dbcontext.Executeall<int>(query, new
            {
                transaction.STUDENT_ID,
                transaction.FREQUENCY,
                transaction.CLASS,
                transaction.PAYMENT_DATE,
                transaction.RECEIPT_NO,
                transaction.PAYMENT_MODE,
                transaction.DD_CHEQUE_NO,
                transaction.COLLECTED,
                transaction.DISCOUNT,
                transaction.DEDUCT_STUDENT_ACCOUNT,
                transaction.RECEIPT_NARRATION,
                transaction.USERNAME,
                transaction.ACADEMIC_YEAR,
                transaction.IS_DELETED,
                transaction.IS_AMOUNT_COLLECTED,
                transaction.IS_ACCOUNTANT_COLLECTED,
                transaction.IS_ADVANCE,
                transaction.UPLOAD_FLAG,
                transaction.IS_DOWNLOADED,
                transaction.IS_UPDATED,
                transaction.DOWNLOAD_TIME,
                transaction.FEE_TRANSACTION_COUNTER,
                transaction.FEE_TRANSACTION_BANK,
                transaction.TEMP_ID,
                transaction.EXCESS_AMT,
                transaction.F_TRANSACTION_ID,
                transaction.FREQUENCY_TO,
                transaction.CHALLAN_NO,
                transaction.PayUResponse_Id,
                transaction.RAZORPAY_ID,
                transaction.RECEIPT_NO1,
                transaction.RECEIPT_NO2,
                transaction.EASEPAYID
            });
        }



        public async Task<int?> GetFeeMainHeadIdAsync(int campusId, int applicationTypeId, int shift,int fid)
        {
            const string query = @"
        SELECT fee_main_head_id 
        FROM campus_360_uat.fee_main_heads 
        WHERE campus_id = @CampusId
            AND application_type_id = @ApplicationTypeId
            AND shift = @Shift and FREQUENCY_ID=@Fid
            AND is_deleted != 1
        LIMIT 1;
    ";
            var actualShift = (campusId == 1 && fid == 36) ? 1 : shift;

            var debugQuery = $@"
        SELECT fee_main_head_id 
        FROM fee_main_heads 
        WHERE campus_id = {campusId}
            AND application_type_id = {applicationTypeId}
            AND shift = {actualShift}
            AND FREQUENCY_ID = {fid}
            AND is_deleted != 1
        LIMIT 1;
    ";
            //Console.WriteLine("Executing FeeMianheadSQL:\n" + debugQuery);

            var result = await _dbcontext.Executeall<int?>(query, new
            {
                CampusId = campusId,
                ApplicationTypeId = applicationTypeId,
                Shift = actualShift,
                Fid =fid
            });

            return result;
        }


        public async Task InsertFeeCollectionAsync(FeeCollection collection)
        {
            const string query = @"
        INSERT INTO campus_360_uat.fee_collection (
            TRANSACTION_ID,
            HEAD,
            PAID_AMOUNT,
            IS_DOWNLOADED,
            IS_UPDATED,
            DOWNLOAD_TIME,
            FREQUENCY,
            RECEIPT_NO,
            SORT_ORDER,
            IS_DELETED,
            TEMP_ID,
            FEE_MAIN_HEAD_ID,
            SETTLEMENT_DATE,
            B_SETTLEMENT_DATE,
            FEE_RAZORPAY_TRANSFER_ID,
            FEE_RAZORPAY_SETTLEMENT_ID
        )
        VALUES (
            @TRANSACTION_ID,
            @HEAD,
            @PAID_AMOUNT,
            @IS_DOWNLOADED,
            @IS_UPDATED,
            @DOWNLOAD_TIME,
            @FREQUENCY,
            @RECEIPT_NO,
            @SORT_ORDER,
            @IS_DELETED,
            @TEMP_ID,
            @FEE_MAIN_HEAD_ID,
            @SETTLEMENT_DATE,
            @B_SETTLEMENT_DATE,
            @FEE_RAZORPAY_TRANSFER_ID,
            @FEE_RAZORPAY_SETTLEMENT_ID
        );
    ";

            await _dbcontext.Execute(query, new
            {
                collection.TRANSACTION_ID,
                collection.HEAD,
                collection.PAID_AMOUNT,
                collection.IS_DOWNLOADED,
                collection.IS_UPDATED,
                collection.DOWNLOAD_TIME,
                collection.FREQUENCY,
                collection.RECEIPT_NO,
                collection.SORT_ORDER,
                collection.IS_DELETED,
                collection.TEMP_ID,
                collection.FEE_MAIN_HEAD_ID,
                collection.SETTLEMENT_DATE,
                collection.B_SETTLEMENT_DATE,
                collection.FEE_RAZORPAY_TRANSFER_ID,
                collection.FEE_RAZORPAY_SETTLEMENT_ID
            });
        }



        public async Task<int?> GetFeeStructureId(int? PGRID,int fid,int CampusID)
        {

            /*const string query = @"SELECT * FROM FEE_STRUCTURE AS FEST INNER JOIN  CP_PROGRAMME AS CPG ON FEST.PROGRAMME=CPG.PROGRAMME_ID  
            AND FEST.IS_DELETED!=1 AND FEST.CAMPUS_ID=@campid WHERE FEST.ACADEMIC_YEAR=2025 AND CPG.IS_DELETED!=1 
            AND FEST.FREQUENCY=@fid AND CPG.PROGRAMME_CODE=@PGMCODE AND CPG.CAMPUS_ID=@campid;";
            const String query = "SELECT FEE_STRUCTURE_ID FROM FEE_STRUCTURE AS FEST INNER JOIN CP_PROGRAMME_GROUP AS CPG ON FEST.PROGRAMME = CPG.PROGRAMME_GROUP_ID AND CPG.CAMPUS_ID = @campid " +
                "INNER JOIN (SELECT * FROM CP_PROGRAMME WHERE PROGRAMME_CODE=@PGMCODE) AS CP ON CPG.PROGRAMME_ID=CP.PROGRAMME_ID WHERE FEST.FREQUENCY=@fid AND FEST.CAMPUS_ID=@campid;"; */
            const String query = @"SELECT FEE_STRUCTURE_ID FROM campus_360_uat.FEE_STRUCTURE WHERE PROGRAMME=@PGRID AND FREQUENCY=@fid and campus_id=@campid and is_deleted!=1 limit 1;";
            /*string debugQuery = $@"
        SELECT FEE_STRUCTURE_ID 
        FROM FEE_STRUCTURE 
        WHERE PROGRAMME = {PGRID} 
            AND FREQUENCY = {fid} 
            AND CAMPUS_ID = {CampusID} 
            AND IS_DELETED != 1 
        LIMIT 1;
    ";

            Console.WriteLine(debugQuery); */

            return await  _dbcontext.Executeall<int?>(query, new { PGRID,fid,campid=CampusID });
        }

        public async Task<int> InsertFeeStudentAccountCreditAsync(FeeStdAccount account)
        {
            const string query = @"
                        INSERT INTO campus_360_uat.fee_student_account (
                            STUDENT_AC_ID,
                            STUDENT_ID,
                            ACADEMIC_YEAR,
                            FREQUENCY_ID,
                            HEAD,
                            CREDIT,
                            DEBIT,
                            TRANSACTION_DATE,
                            DISCOUNT_ID,
                            STU_DISCOUNT_ID,
                            IS_DELETED,
                            TRANSACTION_ID,
                            BANK,
                            IS_REFUND,
                            SPONSOR_ID,
                            FINE_DATE,
                            IS_CANCELLED_HEAD,
                            FEE_MAIN_HEAD_ID,
                            INSTALLMENT_ID,
                            REASON,
                            FEE_STRUCTURE_ID
                        )
                        VALUES (
                            @STUDENT_AC_ID,
                            @STUDENT_ID,
                            @ACADEMIC_YEAR,
                            @FREQUENCY_ID,
                            @HEAD,
                            @CREDIT,
                            @DEBIT,
                            @TRANSACTION_DATE,
                            @DISCOUNT_ID,
                            @STU_DISCOUNT_ID,
                            @IS_DELETED,
                            @TRANSACTION_ID,
                            @BANK,
                            @IS_REFUND,
                            @SPONSOR_ID,
                            @FINE_DATE,
                            @IS_CANCELLED_HEAD,
                            @FEE_MAIN_HEAD_ID,
                            @INSTALLMENT_ID,
                            @REASON,
                            @FEE_STRUCTURE_ID
                        );
                    ";

            return await _dbcontext.Executeall<int>(query, new
            {
                account.STUDENT_AC_ID,
                account.STUDENT_ID,
                account.ACADEMIC_YEAR,
                account.FREQUENCY_ID,
                account.HEAD,
                account.CREDIT,
                account.DEBIT,
                account.TRANSACTION_DATE,
                account.DISCOUNT_ID,
                account.STU_DISCOUNT_ID,
                account.IS_DELETED,
                account.TRANSACTION_ID,
                account.BANK,
                account.IS_REFUND,
                account.SPONSOR_ID,
                account.FINE_DATE,
                account.IS_CANCELLED_HEAD,
                account.FEE_MAIN_HEAD_ID,
                account.INSTALLMENT_ID,
                account.REASON,
                account.FEE_STRUCTURE_ID
            });
        }



        public async Task InsertFeeStudentAccountDebitAsync(FeeStdAccount account)
        {
            const string query = @"
                            INSERT INTO campus_360_uat.fee_student_account (
                                F_STUDENT_AC_ID,
                                STUDENT_AC_ID,
                                STUDENT_ID,
                                ACADEMIC_YEAR,
                                FREQUENCY_ID,
                                HEAD,
                                CREDIT,
                                DEBIT,
                                TRANSACTION_DATE,
                                DISCOUNT_ID,
                                STU_DISCOUNT_ID,
                                IS_DELETED,
                                TRANSACTION_ID,
                                BANK,
                                IS_REFUND,
                                SPONSOR_ID,
                                FINE_DATE,
                                IS_CANCELLED_HEAD,
                                FEE_MAIN_HEAD_ID,
                                INSTALLMENT_ID,
                                REASON,
                                FEE_STRUCTURE_ID
                            )
                            VALUES (
                                @F_STUDENT_AC_ID,
                                @STUDENT_AC_ID,
                                @STUDENT_ID,
                                @ACADEMIC_YEAR,
                                @FREQUENCY_ID,
                                @HEAD,
                                @CREDIT,
                                @DEBIT,
                                @TRANSACTION_DATE,
                                @DISCOUNT_ID,
                                @STU_DISCOUNT_ID,
                                @IS_DELETED,
                                @TRANSACTION_ID,
                                @BANK,
                                @IS_REFUND,
                                @SPONSOR_ID,
                                @FINE_DATE,
                                @IS_CANCELLED_HEAD,
                                @FEE_MAIN_HEAD_ID,
                                @INSTALLMENT_ID,
                                @REASON,
                                @FEE_STRUCTURE_ID
                            );
                        ";

            await _dbcontext.Execute(query, new
            {
                account.F_STUDENT_AC_ID,
                account.STUDENT_AC_ID,
                account.STUDENT_ID,
                account.ACADEMIC_YEAR,
                account.FREQUENCY_ID,
                account.HEAD,
                account.CREDIT,
                account.DEBIT,
                account.TRANSACTION_DATE,
                account.DISCOUNT_ID,
                account.STU_DISCOUNT_ID,
                account.IS_DELETED,
                account.TRANSACTION_ID,
                account.BANK,
                account.IS_REFUND,
                account.SPONSOR_ID,
                account.FINE_DATE,
                account.IS_CANCELLED_HEAD,
                account.FEE_MAIN_HEAD_ID,
                account.INSTALLMENT_ID,
                account.REASON,
                account.FEE_STRUCTURE_ID
            });
        }


        public async Task<IEnumerable<AutoGenerateNumbera>> FetchAutoGenerateNumberForAdmission(int programmeMode)
        {
            /*const String query1=@"SELECT 
                            auto_generate_numbers_id,
                            exam_receipt_no,
                            SUM(advance_receipt_no + 1) AS advance_receipt_no,
                            advance_receipt_prefix,
                            fr_receipt_no,
                            library_receript_no,
                            SUM(Access_No + 1) AS Access_No
                        FROM
                            campus_360_uat.AUTO_GENERATE_NUMBERS
                        WHERE
                            PROGRAMME_MODE=@PROGRAMME_MODE;";*/
            const String query1 = @"SELECT 
                            auto_generate_numbers_id,
                            exam_receipt_no,
                            advance_receipt_no + 1 AS advance_receipt_no,
                            advance_receipt_prefix,
                            fr_receipt_no,
                            library_receript_no,
                            Access_No + 1 AS Access_No
                        FROM
                            campus_360_uat.AUTO_GENERATE_NUMBERS
                        WHERE
                            PROGRAMME_MODE=@PROGRAMME_MODE;";
            return await _dbcontext.Getall<AutoGenerateNumbera>(query1, new { PROGRAMME_MODE = programmeMode });
            //return await _dbcontext.Executeall<int?>(query, new { campid, PGMCODE, shift })
        }

        public async Task UpdateAutoGenerateNumber(AutoGenerateNumbera entity)
        {
            const string sql = @"
        UPDATE campus_360_uat.AUTO_GENERATE_NUMBERS 
        SET 
            EXAM_RECEIPT_NO = @EXAM_RECEIPT_NO,
            ADVANCE_RECEIPT_NO = @ADVANCE_RECEIPT_NO,
            FR_RECEIPT_NO = @FR_RECEIPT_NO,
            LIBRARY_RECERIPT_NO = @LIBRARY_RECERIPT_NO
        WHERE
            AUTO_GENERATE_NUMBERS_ID = @AUTO_GENERATE_NUMBERS_ID;
    ";

            await _dbcontext.ExecuteAsync(sql,entity);
        }



       

    }
}
