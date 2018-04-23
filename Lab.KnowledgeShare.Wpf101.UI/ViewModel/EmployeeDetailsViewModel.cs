using Lab.KnowledgeShare.Wpf101.Model;
using Lab.KnowledgeShare.Wpf101.UI.Common;
using System.ComponentModel;
using System;

namespace Lab.KnowledgeShare.Wpf101.UI.ViewModel
{
    public class EmployeeDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Employee selectedEmployee;

        public EmployeeDetailsViewModel() => Messenger.Default.Register<Employee>(this, OnSelectEmployee);

        private void OnSelectEmployee(Employee employee) => SelectedEmployee = employee;

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
        private void RaisePropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

