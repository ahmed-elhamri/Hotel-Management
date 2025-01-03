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
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hotel_Management.ViewModels
{
    public class RoomManagementViewModel
    {
        private readonly RoomDAO _roomDao;
        private readonly RoomTypeDAO _roomTypeDao;
        private List<Room> _allRooms;
        private Window _currentWindow;



        public ObservableCollection<Room> Rooms { get; set; }
        public ObservableCollection<RoomType> RoomTypes { get; set; }
        private Room _currentRoom;
        public Room CurrentRoom
        {
            get => _currentRoom;
            set
            {
                _currentRoom = value;
                OnPropertyChanged();
            }
        }

        public string SearchName
        {
            get => _searchName;
            set
            {
                _searchName = value;
                OnPropertyChanged(); // Notifie l'interface utilisateur
            }
        }
        private string _searchName;

        public RoomType SelectedRoomType
        {
            get => _selectedRoomType;
            set
            {
                _selectedRoomType = value;
                OnPropertyChanged(); // Notifie l'interface utilisateur
            }
        }
        private RoomType _selectedRoomType;


        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public ICommand SearchCommand { get; set; }
        public ICommand ExportExcelCommand { get; set; }

        public RoomManagementViewModel()
        {
            _roomDao = new RoomDAO();
            _roomTypeDao = new RoomTypeDAO();


            RoomTypes = new ObservableCollection<RoomType>(_roomTypeDao.GetAllRoomTypes());
            _allRooms = _roomDao.GetAllRooms(); // Store all rooms
            Rooms = new ObservableCollection<Room>(_allRooms);

            AddCommand = new RelayCommand(_ => OpenPopup(new Room { IsAvailable = true }));
            UpdateCommand = new RelayCommand(room => OpenPopup((Room)room));
            DeleteCommand = new RelayCommand(room => DeleteRoom((Room)room));
            SaveCommand = new RelayCommand(_ => SaveRoom());
            ExportExcelCommand = new RelayCommand(_ => ExportToExcel());
            SearchCommand = new RelayCommand(_ => FilterRooms());
        }

        private void FilterRooms()
        {
            var filteredRooms = _allRooms.AsQueryable();

            if (!string.IsNullOrWhiteSpace(SearchName))
            {
                filteredRooms = filteredRooms.Where(r => r.Name.Contains(SearchName, StringComparison.OrdinalIgnoreCase));
            }

            if (SelectedRoomType != null)
            {
                filteredRooms = filteredRooms.Where(r => r.RoomTypeId == SelectedRoomType.Id);
            }

            Rooms.Clear();
            foreach (var room in filteredRooms)
            {
                Rooms.Add(room);
            }
        }

        private void OpenPopup(Room room)
        {
            CurrentRoom = room;
            _currentWindow = new AddUpdateRoomWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeleteRoom(Room room)
        {
            MessageBoxResult response = MessageBox.Show("Voulez vous supprimer cette chambre", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (response == MessageBoxResult.No)
            {
                return;
            }
            _roomDao.DeleteRoom(room);
            Rooms.Remove(room);
        }

        private void SaveRoom()
        {
            string validationMessage = ValidateRoom();

            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Create a new Room instance for update to avoid reference issues
            var roomToSave = new Room
            {
                Id = CurrentRoom.Id,
                Name = CurrentRoom.Name,
                Capacity = CurrentRoom.Capacity,
                Price = CurrentRoom.Price,
                IsAvailable = CurrentRoom.IsAvailable,
                RoomTypeId = CurrentRoom.RoomType.Id,
                RoomType = RoomTypes.First(rt => rt.Id == CurrentRoom.RoomType.Id)
            };

            if (roomToSave.Id == 0)
            {
                _roomDao.AddRoom(roomToSave);
                Rooms.Add(roomToSave);
            }
            else
            {
                _roomDao.UpdateRoom(roomToSave);
                var index = Rooms.IndexOf(Rooms.First(u => u.Id == roomToSave.Id));
                Rooms[index] = roomToSave;
            }

            // Refresh the rooms list to ensure proper references
            _allRooms = _roomDao.GetAllRooms();
            Rooms = new ObservableCollection<Room>(_allRooms);

            _currentWindow?.Close();
            _allRooms = _roomDao.GetAllRooms();
            Rooms.Clear();
            foreach (var updatedRoom in _allRooms)
            {
                Rooms.Add(updatedRoom);
            }
        }

        private string ValidateRoom()
        {
            if (string.IsNullOrWhiteSpace(CurrentRoom.Name))
                return "Le nom de la chambre est requis.";

            if (!int.TryParse(CurrentRoom.Capacity.ToString(), out int capacity) || capacity <= 0)
                return "La capacité doit être un entier positif.";

            if (!double.TryParse(CurrentRoom.Price.ToString(), out double price) || price <= 0)
                return "Le prix doit être un nombre positif.";

            if (CurrentRoom.RoomType == null)
                return "Le type de chambre est requis.";

            return null; // No errors
        }

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


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
