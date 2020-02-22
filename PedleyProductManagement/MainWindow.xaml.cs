using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PedleyProductManagement
{
    public partial class MainWindow : Window
    {
        CreateJob CreateJobWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Buttons from file
        private void BtnFileExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


        //Buttons from jobs
        private void BtnJobsCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateJobWindow = new CreateJob();
            CreateJobWindow.Show();
        }

        
        private void BtnJobsLoad_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
