using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class QuizMatchtheFollowing
    {
        public string QUIZ_ID { get; set; }
        public string ENTRY_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string ANSWER_ID { get; set; }
        public string ANSWER { get; set; }
        public string QUESTION { get; set; }
        public string MARK { get; set; }
        public string SET_ID { get; set; }
        public string QUESTION_TYPE_ID { get; set; }
        public string QUESTION_TYPE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SETTING_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string NO_OF_QUESTIONS { get; set; }
    }

    public class QuizList
    {
        public string QUESTION { get; set; }
        public string QUESTION_TYPE_ID { get; set; }
        public string QUESTION_TYPE { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string QUESTION_ID { get; set; }
        public string ANSWER { get; set; }
        public string CLASS_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string QUIZ_ID { get; set; }
        public string SET_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string MARK { get; set; }
    }

    public class QuizQuestion
    {
        public string QUIZ_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string QUESTION { get; set; }
        public string COURSE_ID { get; set; }
        public string SET_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string ANSWER_ID { get; set; }
        public string QUESTION_TYPE { get; set; }
        public string MARK { get; set; }
        public string SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }
        public string NO_OF_QUESTIONS { get; set; }
        public string SEMESTER_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ENTRY_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string SET_NAME { get; set; }
        public string QUESTION_TYPE_ID { get; set; }
        public string OPTION_ID { get; set; }
        public string OPTION { get; set; }
        public string STUDENT_ID { get; set; }
        public string CORRECT_OPTION_ID { get; set; }
        public string STUDENT_CHOSEN_OPTION_ID { get; set; }
    }

    public class QuizOption
    {
        public string OPTION_ID { get;set; }
        public string OPTION { get;set; }
        public string SEMESTER_ID { get;set; }
        public string QUIZ_ID { get;set; }
        public string SET_ID { get;set; }
        public string MARK { get;set; }
        public string SETTING_ID { get;set; }
        public string CAMPUS_ID { get;set; }
        public string QUESTION_TYPE { get;set; }
        public string ANSWER { get;set; }
        public string QUESTION { get;set; }
    }
}
