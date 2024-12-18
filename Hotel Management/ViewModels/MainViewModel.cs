using Hotel_Management.Commands;
using Hotel_Management.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hotel_Management.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public ICommand NavigateCommand { get; }

        public MainViewModel()
        {
            NavigateCommand = new RelayCommand(ExecuteNavigateCommand);
            CurrentView = new DashboardView(); // Default view
        }

        private void ExecuteNavigateCommand(object viewName)
        {
            switch (viewName)
            {
                case "DashboardView":
                    CurrentView = new DashboardView();
                    break;
                case "ListEmployesView":
                    CurrentView = new ListEmployesView();
                    break;
                case "ListClientsView":
                    CurrentView = new ListClientsView();
                    break;
                case "ListRoomsView":
                    CurrentView = new ListRoomsView();
                    break;
                case "ListReservationsView":
                    CurrentView = new ListReservationsView();
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
