using Lab.KnowledgeShare.Wpf101.UI.Services;
using Lab.KnowledgeShare.Wpf101.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.KnowledgeShare.Wpf101.UI
{
    public class ViewModelLocator
    {
        private static IDialogService dialogService = new DialogService();
        private static IEmployeeService employeeService = new EmployeeService();
        

        private static EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel();
        private static EmployeeViewModel employeeViewModel = new EmployeeViewModel(employeeService,dialogService);
        

        public static EmployeeDetailsViewModel EmployeeDetailsViewModel => employeeDetailsViewModel;
        public static EmployeeViewModel EmployeeViewModel => employeeViewModel;
        


    }
}
