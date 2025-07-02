using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class LIBookInfoDTO
    {
        public string BOOK_ID { get; set; }
        public string LI_CODE_ID { get; set; }
        public string ACCESS_NO { get; set; }
        public string CLASS_NO_ID { get; set; }
        public string BOOK_NO { get; set; }
        public string ISBN_NO { get; set; }
        public string LANGUAGE_NAME { get; set; }
        public string DOC_TITLE { get; set; }
        public string PARALLEL_TITLE { get; set; }
        public string NOTES { get; set; }
        public string PERSONAL_AUTHOR1 { get; set; }
        public string PERSONAL_AUTHOR2 { get; set; }
        public string JOINED_AUTHOR1 { get; set; }
        public string JOINED_AUTHOR2 { get; set; }
        public string CORPORATE_AUTHOR1 { get; set; }
        public string CORPORATE_AUTHOR2 { get; set; }
        public string NAME_OF_PUBLISHER { get; set; }
        public string PLACE_OF_PUBLISHER { get; set; }
        public string STATUS_ID { get; set; }
        public string PRICE { get; set; }
        public string DOP { get; set; }
        public string NUMBER_OF_COPIES { get; set; }
        public string LI_CATEGORY_ID { get; set; }
        public string DOC_CATEGORY_ID { get; set; }
        public string BOOK_PUBLISH_YEAR { get; set; }
        public string CALL_NO { get; set; }
        public string BARCODE { get; set; }
        public string RFID { get; set; }
        public string RACK_ID { get; set; }
        public string ACCOUNT_ID { get; set; }
        public string KEYWORD { get; set; }
        public string BILL_NO { get; set; }
        public string BILL_AMOUNT { get; set; }
        public string BILL_DATE { get; set; }
        public string SECTION_ID { get; set; }
        public string SUPPLIER_NAME { get; set; }
        public string SUPPLIER_ADDRESS { get; set; }
        public string BOOK_STATUS_ID { get; set; }
        public string SUBJECT_ID { get; set; }
        public string LI_ACADEMIC_YEAR_ID { get; set; }
        public string IS_WEEDED_BOOK { get; set; }
        public string CAMPUS_ID { get; set; }
    }

    public class LIBookRFIDUpdateDTO
    {
        public string BOOK_ID { get; set; }
        public string BARCODE { get; set; }
        public string RFID { get; set; }
    }
}
