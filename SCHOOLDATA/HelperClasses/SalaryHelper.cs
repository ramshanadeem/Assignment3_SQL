using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOLDATA.HelperClasses
{
    public class SalaryHelper
    {
        public void AddSalary(string Id, int AccountNo,int Salary)
        {
            SalaryDetail salary = new SalaryDetail();
            salary.TeacherId = Id;
            salary.AccountNumber = AccountNo;
            salary.Salary = Salary;
           

            var db = new SchoolEntities();
            db.SalaryDetails.Add(salary);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
