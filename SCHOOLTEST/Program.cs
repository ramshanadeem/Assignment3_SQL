using SCHOOLDATA.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOLTEST
{
    public class Program
    {
        public static void Main()
        {
            StudentHelper stdhelper = new StudentHelper();
            stdhelper.AddStudent("11", "Ramsha", "Nadeem", "North Karachi", true, "03342954361");
            ResultHelper reshelper = new ResultHelper();
            reshelper.AddResult("01", 2020, "A+");
            TeacherHelper teacherhelper = new TeacherHelper();
            teacherhelper.AddTeacher("001", "Shamim", "Female", "Mathematics", "Permanant Faculty", 01358444556);
            SalaryHelper salaryhelper = new SalaryHelper();
            salaryhelper.AddSalary("001", 1222, 15000);
        }
    }
}
