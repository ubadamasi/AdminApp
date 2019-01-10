using Admin.App.Mvc.Data;
using Admin.App.Mvc.Dtos;
using Admin.App.Mvc.Models;
using Admin.App.Mvc.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.App.Mvc.Controllers
{
    public class EmployeeController : Controller
    {

        #region Declearation
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
        #endregion


        // GET: Employee
        public ActionResult Index()
        {
            var employees = _db.Employees.Include(x => x.Gender).ToList();
            return View(employees);
        }

        public ActionResult New()
        {
            var gender = _db.Genders.ToList();

            var viewModel = new EmployeeFormViewModel
            {
                Employee = new Employee(),
                Genders = gender
            };
            
            return View("EmployeeForm", viewModel);
        }

        public ActionResult Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                var gender = _db.Genders.ToList();

                var viewModel = new EmployeeFormViewModel
                {
                    Employee = new Employee(),
                    Genders = gender
                };

                return View("EmployeeForm", viewModel);
            }
            else
            {
                _db.Employees.Add(employee);
            }

            _db.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }
    }
}