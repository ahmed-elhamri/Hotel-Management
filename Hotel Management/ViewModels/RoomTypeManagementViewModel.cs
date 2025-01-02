using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views.Admin.Employes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Hotel_Management.Views.Admin.RoomTypes;

namespace Hotel_Management.ViewModels
{
    public class RoomTypeManagementViewModel
    {
        private readonly RoomTypeDAO _roomTypeDao;
        private Window _currentWindow;
        private string _tempPassword;

        public ObservableCollection<RoomType> RoomTypes { get; set; }
        public RoomType CurrentRoomType { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public RoomTypeManagementViewModel()
        {
            _roomTypeDao = new RoomTypeDAO();
            RoomTypes = new ObservableCollection<RoomType>(_roomTypeDao.GetAllRoomTypes());

            AddCommand = new RelayCommand(_ => OpenPopup(new RoomType()));
            UpdateCommand = new RelayCommand(roomType => OpenPopup((RoomType)roomType));
            DeleteCommand = new RelayCommand(roomType => DeleteRoomType((RoomType)roomType));
            SaveCommand = new RelayCommand(_ => SaveRoomType());
        }

        private void OpenPopup(RoomType roomType)
        {
            CurrentRoomType = roomType;
            _currentWindow = new AddUpdateRoomTypeWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeleteRoomType(RoomType roomType)
        {
            MessageBoxResult response = MessageBox.Show("Voulez vous supprimer cette categorie", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (response == MessageBoxResult.No)
            {
                return;
            }
            _roomTypeDao.DeleteRoomType(roomType);
            RoomTypes.Remove(roomType);
        }

        private void SaveRoomType()
        {
            if (CurrentRoomType.Id == 0)
            {
                _roomTypeDao.AddRoomType(CurrentRoomType);
                RoomTypes.Add(CurrentRoomType);
            }
            else
            {
                _roomTypeDao.UpdateRoomType(CurrentRoomType);
                var index = RoomTypes.IndexOf(RoomTypes.First(u => u.Id == CurrentRoomType.Id));
                RoomTypes[index] = CurrentRoomType;
            }

            _currentWindow?.Close();
        }
    }
}

