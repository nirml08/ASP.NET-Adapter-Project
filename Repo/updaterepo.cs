using adapter.Model.classmodel;
using adapter.Dbpool;
using System.Threading.RateLimiting;
using adapter.Model.apicaldata;
using Humanizer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace adapter.Repo
{
    public class updaterepo
    {
        public readonly dbcontext _dbcontext;
        public updaterepo(dbcontext dbcon)
        {
            _dbcontext = dbcon;
        }

        public async Task<int?> GetProgrammeId(String PGMCODE1, int campid, int shift, int appltype)
        {
            string PGMCODE = "";
            if (PGMCODE1 == "Data Science")
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

            var result = await _dbcontext.Executeall<int?>(query, new { campid, PGMCODE, shift, appltype });
            if (result == null)
            {
                Console.WriteLine($"No PGID found for \n {query}");
                // handle "no result" case
            }
            return result;
        }

        public async Task<int> GetRecieveId(string application_id)
        {
            const string query = @"
            SELECT receive_id
            FROM campus_360_uat.adm_issued_applications
            WHERE application_no=@application_id
            LIMIT 1;";

            var result=await _dbcontext.Executeall<int?>(query, new { application_id });

            if (result == null)
                {
                    Console.WriteLine($"No Receive+ID found for \n {query}");
                    // handle "no result" case
                }
            return result;
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
            await _dbcontext.Execute(query, new
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




    }
}