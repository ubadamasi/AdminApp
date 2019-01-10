using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.App.Mvc.Models
{
    public class Employee
    {
        public byte Id { get; set; }
        public string StaffID { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HiredDate { get; set; }
        public virtual Gender Gender { get; set; }

    }
}