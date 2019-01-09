using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.App.MVC.Models
{
    public class Employee
    {
        public byte Id { get; set; }
        public string EmployeeID { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateHired { get; set; }
        public string Address { get; set; }
        public State State { get; set; }
        public LocalGovernment LocalGovernment { get; set; }
    }
}