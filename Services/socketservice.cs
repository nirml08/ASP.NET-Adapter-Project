using adapter.Model.classmodel;
using adapter.Repo;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Build.Framework;

namespace adapter.Services
{
    public class socketservice 
    {
        private readonly socketrepo _socketrepo;

        public socketservice(socketrepo sockrepo)
        {
            _socketrepo = sockrepo
;        }
            public async Task<IEnumerable<StudentClass>> FetchSelectedStudent(String _rollno)
            {
                string rln = _rollno;
                var pll_fetching = new List<Task<IEnumerable<CourseRoot>>>();
                var students= (await _socketrepo.FetchSelectedStudent(rln)).ToList();
                foreach (var std in students)   
                {
                     //Console.WriteLine($"Name: {std.FIRST_NAME+std.LAST_NAME}, Roll: {std.ROLL_NO}, Email: {std.MAIL_ID}");
                    var _tasks= _socketrepo.FetchRealtedCourse(Convert.ToInt32(std.STUDENT_ID));
                    pll_fetching.Add(_tasks);
                }

                var taskresult = await Task.WhenAll(pll_fetching);

                foreach(var CourseList in taskresult)
                {
                foreach (var course in CourseList)
                {
                    Console.WriteLine($"{course.COURSE_TITLE},{course.COURSE_CODE}");
                }
                }
                return students;
            }


    }
}
