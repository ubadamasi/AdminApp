using Admin.App.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.App.Mvc.Data
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Remove(Employee employee);
        Task<Employee> GetEmployee(byte id);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<bool> SaveAll();
    }
}
