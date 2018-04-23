using Lab.KnowledgeShare.Wpf101.Model;
using Lab.KnowledgeShare.Wpf101.UI.Common;
using Lab.KnowledgeShare.Wpf101.UI.Extensions;
using Lab.KnowledgeShare.Wpf101.UI.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Lab.KnowledgeShare.Wpf101.UI.ViewModel
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Employee> employees;
        private Employee selectedEmployee;
        private IDialogService _dialogService;
        private IEmployeeService _employeeService;

        public ICommand AddEmployeeCommand { get; set; }
        public ICommand DetailsEmployeeCommand { get; set; }

        public EmployeeViewModel(IEmployeeService employeeService, IDialogService dialogService)
        {
            _employeeService = employeeService;
            _dialogService = dialogService;
            LoadData();
            LoadCommands();
        }

        private void LoadCommands()
        {
            DetailsEmployeeCommand = new CustomCommand(DisplayEmployeeDetails, CanDisplatEmployee);
            AddEmployeeCommand = new CustomCommand(AddEmployee, CanAddEmployee);
        }

        private bool CanAddEmployee(object obj)
        {
            return true;
        }

        private void AddEmployee(object obj)
        {
            Employee addEmployee = new Employee
            {
                Id = 119,
                FirstName = "QQQQ",
                LastName = "RRRR",
                Position = "Director",
                Salary = 130000,
                ImageId = 1
            };
            employees.Add(addEmployee);
        }

        private bool CanDisplatEmployee(object obj)
        {
            return selectedEmployee != null;
        }

        private void DisplayEmployeeDetails(object obj)
        {
            Messenger.Default.Send<Employee>(selectedEmployee);
            _dialogService.ShowEmployeeDetailView();
        }

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
                RaisePropertyChanged("Employees");
            }
        }

        public Employee SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                selectedEmployee = value;
                RaisePropertyChanged("SelectedEmployee");
            }
        }
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadData()
        {
            employees = _employeeService.GetEmployees().ToObservableCollection();
            
        }
    }
}
