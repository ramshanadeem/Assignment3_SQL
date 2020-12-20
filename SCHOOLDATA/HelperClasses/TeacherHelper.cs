using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOLDATA.HelperClasses
{
    public class TeacherHelper
    {
        public void AddTeacher(string Id, string Name,string Gender,string Subject,string Status,int ContactNo)
        {
            TeachersInfo techer = new TeachersInfo();
            techer.TeacherId = Id;
            techer.TeacherName = Name;
            techer.Gender = Gender;
            techer.Subject = Subject;
            techer.Status = Status;
            techer.ContactNumber = ContactNo;

            var db = new SchoolEntities();
            db.TeachersInfoes.Add(techer);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
