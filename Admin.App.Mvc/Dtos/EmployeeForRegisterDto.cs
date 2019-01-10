using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.App.Mvc.Dtos
{
    public class EmployeeForRegisterDto
    {
        public byte Id { get; set; }
        public string StaffID { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HiredDate { get; set; }
        public byte Gender { get; set; }
    }
}