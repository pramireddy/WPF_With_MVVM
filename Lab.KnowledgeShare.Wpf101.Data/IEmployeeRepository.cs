using Lab.KnowledgeShare.Wpf101.Model;
using System.Collections.Generic;

namespace Lab.KnowledgeShare.Wpf101.Data
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        List<Employee> GetEmployees();
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
