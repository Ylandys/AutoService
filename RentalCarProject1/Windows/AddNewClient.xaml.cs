﻿using RentalCarProject1.Resources;
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

namespace RentalCarProject1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddNewClient.xaml
    /// </summary>
    public partial class AddNewClient : Window
    {
        AutoServiceEntities context;
        public AddNewClient(AutoServiceEntities database, Clients client)
        {
            InitializeComponent();
            this.context = database;
            this.DataContext = client;
        }

        private void btn_addClient(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }

        private void btn_exitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
