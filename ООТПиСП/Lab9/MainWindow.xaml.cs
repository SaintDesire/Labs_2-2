using Lab8.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Lab8
{
    public partial class MainWindow : Window
    {
        private Customer customer;
        private Flight flight;
        AviaBookingRepository rep;
        public MainWindow()
        {
            InitializeComponent();
            customer = new Customer();
            flight = new Flight();
            rep = new AviaBookingRepository();

        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            rep.AddCustomer(customer);
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e)
        {
            rep.UpdateCustomer(customer);
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            rep.DeleteCustomer(customer.CustomerId);
        }

        private void AddFlight_Click(object sender, RoutedEventArgs e)
        {
            rep.AddFlight(flight);
        }

        private void EditFlight_Click(object sender, RoutedEventArgs e)
        {
            rep.UpdateFlight(flight);
        }

        private void DeleteFlight_Click(object sender, RoutedEventArgs e)
        {
            rep.DeleteFlight(flight.FlightNumber);
        }
    }
}
