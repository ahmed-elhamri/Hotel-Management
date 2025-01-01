﻿using Hotel_Management.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_Management.Views.Admin.Paiement
{
    /// <summary>
    /// Logique d'interaction pour ListPaiementView.xaml
    /// </summary>
    public partial class ListPaiementView : Window
    {
        public ListPaiementView()
        {
            InitializeComponent();
            this.DataContext = new PaiementManagementViewModel();
        }

    }
}
