using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Vibhu", Department = "HR", Email = "vbk@gmail.com"},
                new Employee() { Id = 2, Name = "Shaheen", Department = "Sales", Email = "sks@gmail.com"},
                new Employee() { Id = 2, Name = "Ishant", Department = "Marketing", Email = "ish@gmail.com"}
            };
        }

        public Employee getEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
