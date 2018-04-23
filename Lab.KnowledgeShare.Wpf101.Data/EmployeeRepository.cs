using System.Collections.Generic;
using System.Linq;
using Lab.KnowledgeShare.Wpf101.Model;

namespace Lab.KnowledgeShare.Wpf101.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> employees;

        public void DeleteEmployee(Employee employee)
        {
            LoadEmployees();
            employees.Remove(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            LoadEmployees();
            return employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            LoadEmployees();
            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            LoadEmployees();
            Employee employeeToUpdate = employees.FirstOrDefault(x => x.Id == employee.Id);
            employeeToUpdate = employee;
        }

        private void LoadEmployees()
        {
            if (employees == null)
            {
                employees = new List<Employee>
                {
                    new Employee{Id=111,FirstName="AAAA",LastName="BBBB",Position="Web Developer",Salary=50000,ImageId=1},
                    new Employee{Id=112,FirstName="CCCC",LastName="DDDD",Position="Web Developer",Salary=60000,ImageId=1},
                    new Employee{Id=113,FirstName="EEEE",LastName="FFFF",Position="Web Developer",Salary=70000,ImageId=1},
                    new Employee{Id=114,FirstName="GGGG",LastName="HHHH",Position="Database Adim",Salary=80000,ImageId=1},
                    new Employee{Id=115,FirstName="IIII",LastName="JJJJ",Position="Business Analyst",Salary=90000,ImageId=1},
                    new Employee{Id=116,FirstName="KKKK",LastName="LLLL",Position="Soultion Architect",Salary=100000,ImageId=1},
                    new Employee{Id=117,FirstName="MMMM",LastName="NNNN",Position="HR Manager",Salary=110000,ImageId=1},
                    new Employee{Id=118,FirstName="OOOO",LastName="PPPP",Position="Senior Manager",Salary=120000,ImageId=1}
                };

            }

        }

    }
}
