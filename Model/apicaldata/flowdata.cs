using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{

        public class ApplicationInfo
        {
            public int? id { get; set; }
            public int? recieve_id { get; set; }
            public string? od_id { get; set;}
            public int Transaction_id { get; set; }
            public string? application_id { get; set; }
            public int? user_id { get; set; }
            public int? reg_id { get; set; }
            public int? dept_id { get; set; }
            public int? course_id { get; set; }
            public string? name { get; set; }
            public string? email { get; set; }
            public string? phone { get; set; }
            public string? dob { get; set; }
            public string? bloodgroup { get; set; }
            public string?  gender { get; set; }
            public int? religion_id { get; set; }
            public string? baptism { get; set; }
            public string? mothertongue { get; set; }
            public string? physically_challanged { get; set; }
            public string? pic { get; set; }
            public string? certificate_x { get; set; }
            public string? certificate_xii { get; set; }
            public string? adhaar_url { get; set; }
            public string? UgDoc { get; set; }

            public string? fname { get; set; }
            public string? foccupation { get; set; }
            public string? fcontact { get; set; }
            public string? mname { get; set; }
            public string? moccupation { get; set; }
            public string? mcontact { get; set; }
            public string? gname { get; set; }
            public string? gcontact { get; set; }
            public int? monthly_income { get; set; }
            public string? permanent_address { get; set; }
            public int? per_pin { get; set; }
            public string? local_address { get; set; }
            public int? loc_pin { get; set; }
            public string? institution10 { get; set; }
            public string? institution12 { get; set; }
            public string? lastinstname { get; set; }
            public string? lastinstdoc { get; set; }
            public string? sub1 { get; set; }
            public string? sub2 { get; set; }
            public string? sub3 { get; set; }
            public string? sub4 { get; set; }
            public string? sub5 { get; set; }
            public string? score1 { get; set; }
            public string? score2 { get; set; }
            public string? score3 { get; set; }
            public string? score4 { get; set; }
            public string? score5 { get; set; }
            public string? sgpa1 { get; set; }
            public string? sgpa2 { get; set; }
            public string? sgpa3 { get; set; }
            public string? sgpa4 { get; set; }
            public string? sgpa5 { get; set; }
            public string? sgpa6 { get; set; }
            public string? certificate_10 { get; set; }
            public string? certificate_12 { get; set; }
            public string? adhaar { get; set; }
            public string? caste { get; set; }
            public string? payment_gateway_id { get; set; }
            public decimal? captured_amount { get; set; }
            public string? payment_gateway_status { get; set; }
            public string? amount_refunded { get; set; }
            public string? captured_currency { get; set; }
            public string? mode { get; set; }
            public string? hash { get; set; }
            public string? msg { get; set; }
            public string? interview_msg { get; set; }
            public DateTime? created_at { get; set; }
            public DateTime? updated_at { get; set; }
            public DateTime? deleted_at { get; set; }
            public string? pic_url { get; set; }
            public Registration? registration { get; set; }
            public Department? dept { get; set; }
            public Course? course { get; set; }
            public Religion? religion_info { get; set; }
            public payment_info? payment_info { get; set; }
    }

        public class Registration
        {
            public int? id { get; set; }
            public int? user_id { get; set; }
            public int? campus { get; set; }
            public int application_type { get; set; }
            public int? country { get; set; }
            public string? application_filled { get; set; }
            public DateTime? created_at { get; set; }
            public DateTime? updated_at { get; set; }
            public Campus? campus_info { get; set; }
            public Country? country_info { get; set; }
            public Program? program_info { get; set; }
        }

        public class Campus
        {
            public int id { get; set; }
            public string slug { get; set; }
            public string name { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class Country
        {
            public int id { get; set; }
            public string name { get; set; }
            public string phone_code { get; set; }
            public string region { get; set; }
        }

        public class Program
        {
            public int id { get; set; }
            public int campus_id { get; set; }
            public string name { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public DateTime? deleted_at { get; set; }
        }

        public class Department
        {
            public int id { get; set; }
            public int campus_id { get; set; }
            public int main_program_id { get; set; }
            public string name { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public DateTime? deleted_at { get; set; }
        }

        public class Course
        {
            public int id { get; set; }
            public int campus_id { get; set; }
            public int main_program_id { get; set; }
            public int department_id { get; set; }
            public string name { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public DateTime? deleted_at { get; set; }
        }

        public class Religion
        {
            public int? id { get; set; }
            public string? name { get; set; }
            public DateTime? created_at { get; set; }
            public DateTime? updated_at { get; set; }
            public DateTime? deleted_at { get; set; }
        }
        public class payment_info
    {
            public int? id { get; set; }
            public string? txnid { get; set; }
            public string? easepayid { get; set; }
            public int? user_id { get; set; }
            public int? amount { get; set; }
            public string? hash { get; set; }
            public string? msg { get; set; }
            public string? status { get; set; }
            public DateTime? created_at { get; set; }
            public DateTime? updated_at { get; set; }
        }

}