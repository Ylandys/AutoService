using Microsoft.Win32;
using RentalCarProject1.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    public partial class AddNewServices : Window
    {
        AutoServiceEntities database;
        public AddNewServices(AutoServiceEntities context1, Services_ service)
        {
            this.database = context1;
            this.DataContext= service;
            InitializeComponent();
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private bool IsMaximized = true;

        private void Border_MouseLeftDown(object sender, MouseButtonEventArgs e)
        {

            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 480;
                    this.Height = 684;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
            }
        }

        private void btn_addClient(object sender, RoutedEventArgs e)
        {
                database.SaveChanges();
            /*Добавление вводимых данных в базу
            car.ServiceName= t2.Text;
            car.Duration= int.Parse(t3.Text);
            car.Cost= decimal.Parse(t4.Text);
            car.Discond = double.Parse(t5.Text);

            MessageBox.Show("Машина успешно добавлена!");


                database.Services_.Add(car);
                this.Close();
            */
        }

        private void btn_exitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
