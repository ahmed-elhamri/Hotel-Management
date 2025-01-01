using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Hotel_Management.Views.Admin.Rooms;
using Hotel_Management.Data;

namespace Hotel_Management.ViewModels
{
    public class RoomManagementViewModel
    {
        private readonly PaiementDAO _roomDao;
        private readonly RoomTypeDAO _roomTypeDao;
        private Window _currentWindow;

        public ObservableCollection<Room> Rooms { get; set; }
        public ObservableCollection<RoomType> RoomTypes { get; set; }
        public Room CurrentRoom { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand ExportExcelCommand { get; set; }

        public RoomManagementViewModel()
        {
            _roomDao = new PaiementDAO();
            _roomTypeDao = new RoomTypeDAO();

            // Only initialize once
            RoomTypes = new ObservableCollection<RoomType>(_roomTypeDao.GetAllRoomTypes());
            Rooms = new ObservableCollection<Room>(_roomDao.GetAllRooms());

            AddCommand = new RelayCommand(_ => OpenPopup(new Room { IsAvailable = true }));
            UpdateCommand = new RelayCommand(room => OpenPopup((Room)room));
            DeleteCommand = new RelayCommand(room => DeleteRoom((Room)room));
            SaveCommand = new RelayCommand(_ => SaveRoom());
           // ExportExcelCommand = new RelayCommand(_ => ExportToExcel());
        }

        private void OpenPopup(Room room)
        {
            CurrentRoom = room;
            _currentWindow = new AddUpdateRoomWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeleteRoom(Room room)
        {
            _roomDao.DeleteRoom(room);
            Rooms.Remove(room);
        }

        private void SaveRoom()
        {
            if (CurrentRoom.Id == 0)
            {
                _roomDao.AddRoom(CurrentRoom);
                Rooms.Add(CurrentRoom);
            }
            else
            {
                _roomDao.UpdateRoom(CurrentRoom);
                var index = Rooms.IndexOf(Rooms.First(u => u.Id == CurrentRoom.Id));
                Rooms[index] = CurrentRoom;
            }

            _currentWindow?.Close();
        }
        /*
        private void ExportToExcel()
        {
            try
            {
                _roomDao.ExportExcel(Rooms.ToList());
                MessageBox.Show("Excel file exported successfully!", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        */
    }

}