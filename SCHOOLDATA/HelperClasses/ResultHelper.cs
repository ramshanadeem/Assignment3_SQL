using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOLDATA.HelperClasses
{
    public class ResultHelper
    {
        public void AddResult(string RollNumber,int PassingYear,string Grades)
        {
            Result20 res = new Result20();
            res.RollNumber = RollNumber;
            res.PassingYear = PassingYear;
            res.Grades = Grades;

            var db = new SchoolEntities();
            db.Result20.Add(res);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
