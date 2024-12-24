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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel_Management.Views.Admin.Employes
{
    /// <summary>
    /// Interaction logic for ListEmployesView.xaml
    /// </summary>
    public partial class ListEmployesView : UserControl
    {
        public ListEmployesView()
        {
            InitializeComponent();
            this.DataContext = new EmployesManagementViewModel(); // Set the DataContext here
            
        }
    }

}