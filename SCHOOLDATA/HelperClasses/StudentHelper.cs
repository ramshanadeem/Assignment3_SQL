using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOLDATA.HelperClasses
{
    public class StudentHelper
    {
        public void AddStudent(string RollNumber, string Name, string FatherName, string Address, bool Gender, string PhoneNumber)
        {
            Student std = new Student();
            std.RollNumber = RollNumber;
            std.Name = Name;
            std.FatherName = FatherName;
            std.Address = Address;
            std.Gender = Gender;
            std.PhoneNumber = PhoneNumber;

            var db =new SchoolEntities();
            db.Students.Add(std);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
