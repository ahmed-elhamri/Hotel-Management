using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using LiveCharts;
using LiveCharts.Wpf;

namespace Hotel_Management.Views.Admin
{
    public partial class DashboardView : UserControl
    {
        private readonly UserDAO _userDAO;
        private readonly RoomDAO _roomDAO;
        private readonly ReservationDAO _reservationDAO;
        private readonly RoomTypeDAO _roomTypeDAO;

        public SeriesCollection SeriesCollection { get; set; }  // Pour le pie chart
        public SeriesCollection MonthlyRevenueSeries { get; set; }  // Pour le graphique des revenus par mois
        public List<string> Months { get; set; }  // Liste des mois pour l'axe X
        public ChartValues<double> MonthlyRevenueValues { get; set; }  // Valeurs des revenus mensuels pour l'axe Y

        public DashboardView()
        {
            InitializeComponent();
            _userDAO = new UserDAO();
            _roomDAO = new RoomDAO();
            _reservationDAO = new ReservationDAO();
            _roomTypeDAO = new RoomTypeDAO();
            LoadDashboardData();
            DataContext = this;  // Lier le DataContext pour les propriétés Binding
        }

        private void LoadDashboardData()
        {
            LoadClientCount();
            LoadRoomCount();
            LoadAvailableRoomsCount();
            LoadTotalPriceOfConfirmedReservations();
            LoadReservationsByRoomType(); // Chargement des données de réservation et des revenus par type de chambre
            LoadRevenueByMonth(); // Chargement des données des revenus mensuels
        }

        private void LoadReservationsByRoomType()
        {
            try
            {
                var reservationsAndRevenue = _roomTypeDAO.GetReservationsAndRevenueByRoomType();

                // Créer la SeriesCollection pour le PieChart
                SeriesCollection = new SeriesCollection();

                // Créer les labels pour les types de chambres
                var labels = reservationsAndRevenue.Keys.ToArray();

                // Ajouter chaque élément dans la SeriesCollection pour alimenter le graphique
                foreach (var item in reservationsAndRevenue)
                {
                    SeriesCollection.Add(new PieSeries
                    {
                        Title = item.Key,
                        Values = new ChartValues<double> { item.Value.TotalRevenue },
                        DataLabels = true,
                        LabelPoint = chartPoint => $"{item.Key}: {chartPoint.Y} "
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données pour le graphique circulaire : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadClientCount()
        {
            try
            {
                // Obtenir le nombre total d'utilisateurs
                int totalUsers = _userDAO.GetTotalUserCount();

                // Mettre à jour l'interface utilisateur
                nbruser.Text = totalUsers.ToString();
            }
            catch (Exception ex)
            {
                // Gérer les erreurs
                ShowError("Erreur lors du chargement des clients", ex);
            }
        }


        private void LoadRoomCount()
        {
            try
            {
                var rooms = _roomDAO.GetAllRooms() ?? new List<Room>();
                nbrtotalroom.Text = rooms.Count.ToString();
            }
            catch (Exception ex)
            {
                ShowError("chargement des chambres", ex);
            }
        }

        private void LoadAvailableRoomsCount()
        {
            try
            {
                int availableRooms = _roomDAO.GetAvailableRoomsCount();
                nbrroodispo.Text = availableRooms.ToString();
            }
            catch (Exception ex)
            {
                ShowError("chargement des chambres disponibles", ex);
            }
        }

        private void LoadTotalPriceOfConfirmedReservations()
        {
            try
            {
                int totalPrice = _reservationDAO.GetTotalPriceOfConfirmedReservations();
                nbrrevunu.Text = totalPrice.ToString("0.00");
            }
            catch (Exception ex)
            {
                ShowError("calcul du total des réservations confirmées", ex);
            }
        }

        private void ShowError(string context, Exception ex)
        {
            MessageBox.Show($"Erreur lors du {context} : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
        }

       private void LoadRevenueByMonth()
{
    try
    {
        // Récupérer les revenus mensuels
        var monthlyRevenue = _reservationDAO.GetMonthlyRevenue();

        // Trier les mois
        var sortedMonths = monthlyRevenue.Keys.OrderBy(month => month).ToList(); // Trie des mois
        var sortedRevenue = sortedMonths.Select(month => monthlyRevenue[month]).ToList(); // Trie des revenus en fonction des mois

        // Créer la SeriesCollection pour les graphiques linéaires
        MonthlyRevenueSeries = new SeriesCollection
        {
            new LineSeries
            {
                Title = "Revenu Mensuel",
                Values = new ChartValues<double>(sortedRevenue),
                PointGeometrySize = 10,
                Fill = System.Windows.Media.Brushes.Transparent,
                Stroke = System.Windows.Media.Brushes.SteelBlue
            }
        };

        // Lier les mois et les valeurs des revenus au graphique
        Months = sortedMonths;
        MonthlyRevenueValues = new ChartValues<double>(sortedRevenue);

        // Mettre à jour le graphique
        RevenueChart.Series = MonthlyRevenueSeries;
        RevenueChart.AxisX[0].Labels = Months.ToArray();
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erreur lors du chargement des revenus mensuels : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}


        private void DashboardView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Code à exécuter lors du clic de la souris
            Console.WriteLine("Mouse Down sur le tableau de bord");
        }

        private void DashboardView_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // Code à exécuter lors du relâchement du clic de la souris
            Console.WriteLine("Mouse Up sur le tableau de bord");
        }
    }
}
