//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCHOOLDATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeachersInfo
    {
        public string TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public int ContactNumber { get; set; }
    
        public virtual SalaryDetail SalaryDetail { get; set; }
    }
}