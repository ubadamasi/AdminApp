using Admin.App.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.App.Mvc.ViewModels
{
    public class EmployeeFormViewModel
    {
        public IEnumerable<Gender> Genders { get; set; }
        public Employee Employee { get; set; }

    }
}