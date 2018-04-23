using Lab.KnowledgeShare.Wpf101.UI.Views;
using System.Windows;

namespace Lab.KnowledgeShare.Wpf101.UI.Services
{
    public class DialogService : IDialogService
    {
        private Window employeeDetailsView = null;

        
        public void CloseEmployeeDetailView()
        {
            if (employeeDetailsView != null)
                employeeDetailsView.Close();
        }

        public void ShowEmployeeDetailView()
        {
            employeeDetailsView = new EmployeeDetailsView();
            employeeDetailsView.ShowDialog();
        }
    }
}
