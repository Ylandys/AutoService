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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RentalCarProject1.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        AutoServiceEntities database;
        public ClientPage()
        {
            database = new AutoServiceEntities();
            InitializeComponent();
            TableClients.ItemsSource = database.Clients.ToList();

        }

        private void btn_AddClient(object sender, RoutedEventArgs e)
        {
            var NewDob = new Clients();
            database.Clients.Add(NewDob);

            AddNewClient newClientWindow = new AddNewClient(database, NewDob);
            newClientWindow.ShowDialog();

            refreshdatagrid();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button reda = sender as Button;
            var reda1 = reda.DataContext as Clients;

            AddNewClient newClientWindow = new AddNewClient(database, reda1);
            newClientWindow.ShowDialog();

            refreshdatagrid();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            database = new AutoServiceEntities();
            Clients item = TableClients.SelectedItem as Clients;
            try
            {
                Clients clients = database.Clients.Where(c => c.Id == item.Id).Single();
                database.Clients.Remove(clients);
                database.SaveChanges();

                MessageBox.Show("Клиент успешно удалён!");
                //Метод обновления таблицы после удаления
                refreshdatagrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshdatagrid()
        {
            TableClients.ItemsSource = database.Clients.ToList();
            TableClients.Items.Refresh();
        }
    }
}
