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

namespace Hotel_Management.Views.Admin.Employes
{
    /// <summary>
    /// Interaction logic for AddUpdateClientWindow.xaml
    /// </summary>
    public partial class AddUpdateEmployeWindow : Window
    {
        public AddUpdateEmployeWindow()
        {
            InitializeComponent();
            this.DataContext = new EmployesManagementViewModel();
        }


    }
}
