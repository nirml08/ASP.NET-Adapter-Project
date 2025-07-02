using System.Threading.Tasks;
using adapter.Model.apicaldata;
using adapter.Model.classmodel;
using adapter.Repo;
using adapter.Repo;

namespace adapter.Services
{
    public class Areceipt
    {
        //private readonly socketrepo _repository;
        public static async Task<int> get_receipt(int pg_mode, socketrepo _repository)
        {
            AutoGenerateNumbera objAutoGenerateNumber = new AutoGenerateNumbera();
            string Prefix = "00";
            int ReceiptNo = 0;
            int receipt_no = 0;
            var FetchReceiptNo = (List<AutoGenerateNumbera>)await _repository.FetchAutoGenerateNumberForAdmission(pg_mode);
            if (FetchReceiptNo != null && FetchReceiptNo.Count > 0)
            {
                ReceiptNo = Convert.ToInt32(FetchReceiptNo.FirstOrDefault().exam_receipt_no);
                receipt_no = ReceiptNo;
                objAutoGenerateNumber.auto_generate_numbers_id = FetchReceiptNo.FirstOrDefault().auto_generate_numbers_id;
            }
            else
            {
                // objResult.ErrorCode = Common.ErrorCode.ExpectationFailed;
                //   objResult.Message = Common.ErrorMessage.ExpectationFailed;
            }

            objAutoGenerateNumber.exam_receipt_no = Convert.ToString(ReceiptNo + 1);
            objAutoGenerateNumber.exam_receipt_no = Prefix + objAutoGenerateNumber.exam_receipt_no;
            await _repository.UpdateAutoGenerateNumber(objAutoGenerateNumber);
            return receipt_no;
        }
        public void update_receipt()
        {

        }

    }
}
