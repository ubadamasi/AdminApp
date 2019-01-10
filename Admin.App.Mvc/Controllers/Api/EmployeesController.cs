using Admin.App.Mvc.Data;
using Admin.App.Mvc.Dtos;
using Admin.App.Mvc.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Admin.App.Mvc.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private IEmployeeRepository _repo;

        public EmployeesController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Index()
        {
            var employees = await _repo.GetEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Register(EmployeeForRegisterDto employeeForRegisterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var mapEmployee = Mapper.Map<EmployeeForRegisterDto, Employee>(employeeForRegisterDto);

            _repo.Add(mapEmployee);
            await _repo.SaveAll();

            return Ok();
        }


        //private IEnumerable<Gender> GetEmployees()
        //{
        //    return new List<Gender>
        //    {
        //        //new Employee { Surname = "Badamasi", Othernames = "Usman", BirthDate = Convert.ToDateTime("3-Jan-1980"), Email ="ubadamasi@nitda.gov.ng", Gender =  , StaffID = "NITDA/HQ/190/P", Phone="07033773336", HiredDate = Convert.ToDateTime("1-dec-2009") }
        //    };
        //}
    }
}
