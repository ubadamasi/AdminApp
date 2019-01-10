using Admin.App.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Admin.App.Mvc.Data
{
    public class EmployeeRepository<T> : IEmployeeRepository
    {

        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        

        public async Task<Employee> GetEmployee(byte id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public void Remove(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}