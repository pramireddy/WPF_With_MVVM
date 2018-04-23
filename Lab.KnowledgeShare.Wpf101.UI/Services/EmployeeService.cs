using System.Collections.Generic;
using Lab.KnowledgeShare.Wpf101.Model;
using Lab.KnowledgeShare.Wpf101.Data;

namespace Lab.KnowledgeShare.Wpf101.UI.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeRepository.DeleteEmployee(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }
    }
}
