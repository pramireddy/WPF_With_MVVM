using Lab.KnowledgeShare.Wpf101.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.KnowledgeShare.Wpf101.UI.Services
{
    public interface IEmployeeService
    {
        Employee GetEmployeeById(int id);
        List<Employee> GetEmployees();
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
