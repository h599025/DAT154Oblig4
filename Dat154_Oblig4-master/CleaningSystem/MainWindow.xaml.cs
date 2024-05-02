using Microsoft.EntityFrameworkCore;
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
using CleaningSystem.Serivces;

namespace CleaningSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Database
        private dat154Context dx = new dat154Context();
        
        //Liste med services fra database
        private DbSet<Service> services;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Sender en liste hvor cleaning ikke er tom
        private void Cleaning (object sender, RoutedEventArgs e)
        {
            var cleaningList = dx.Services.Where(s => s.Cleaning != null).ToList();

            new Tasks(ArrangeData.Cleaning(cleaningList), "Cleaning").Show();
            Close(); //Lukker gammel side
        }

        //Sender en liste hvor service ikke er tom
        private void Service (object sender, RoutedEventArgs e)
        {
            var serviceList = dx.Services.Where(s => s.Service1 != null).ToList();

            new Tasks(ArrangeData.Service(serviceList), "Service").Show();
            Close(); //Lukker gammel side 
        }

        //Sender en liste hvor maintenance ikke er tom
        private void Maintenance (object sender, RoutedEventArgs e)
        {
            var maintenanceList = dx.Services.Where(s => s.Maintenance != null).ToList();

            new Tasks(ArrangeData.Maintenance(maintenanceList), "Maintenance").Show();
            Close(); //Lukker gammel side 
        }

    }
}
