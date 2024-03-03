using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "kto",Department=Dept.HR,Email="kto@gmail.com" },
                new Employee() { Id = 2, Name = "kt",Department=Dept.IT,Email="kt@gmail.com" }
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = -_employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return (employee);
        }

        public Employee Delete(int id)
        {
           Employee employee= _employeeList.FirstOrDefault(e => e.Id == id);
            if(employee!=null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
            
        }

        public Employee Update(Employee employeechanges)
        {
            {
                Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeechanges.Id);
                if (employee != null)
                {
                    employee.Name = employeechanges.Name;
                    employee.Email = employeechanges.Email;
                    employee.Department = employeechanges.Department;
                }
                return employee;
            }
        }
    }
}
