using RentalCarProject1.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RentalCarProject1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        //variables
        AutoServiceEntities database = new AutoServiceEntities();
        public AdminWindow(string UserLogin, string Gender)
        {
            
            InitializeComponent();

            Name.Text += $"Почта: {UserLogin}";
            Role.Text += $"Пол: {Gender}";
            
            if (Gender == "Женский")
            {
                Image.ImageSource = new BitmapImage(new Uri("D:\\RentalCarProject\\RentalCarProject1\\RentalCarProject1\\Resources\\beauty.png", UriKind.Absolute));
            }
            else
            {
                Image.ImageSource = new BitmapImage(new Uri("D:\\RentalCarProject\\RentalCarProject1\\RentalCarProject1\\Resources\\bussiness-man.png", UriKind.Absolute));
            }
           
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if(IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;

                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized=true;
                }
            }
        }

        private void exit_btn(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            MainWindow MW = new MainWindow();
            MW.Show();
        }

        public void Members(object sender, RoutedEventArgs e)
        {

        }

        private void btnServices_Click(object sender, RoutedEventArgs e)
        {
            string roles = Role.Text;

            if (roles == $"Пол: Мужкой")
            {
                Main.Content = new Cars();
            }
            else
            {
                MessageBox.Show("Недостаточно прав для совершения этой операции!");
            }
        }
    }
}
