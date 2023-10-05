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
using HospitalSmrn.ClassHelper;

namespace HospitalSmrn.Windows
{
    /// <summary>
    /// Логика взаимодействия для PatientWindow.xaml
    /// </summary>
    public partial class PatientWindow : Window
    {
        public PatientWindow()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ClassHelper.DataTransmission.GetClient = null;
        }

        private void btnMydata_Click(object sender, RoutedEventArgs e)
        {
            MydataWindow mydataWindow = new MydataWindow();
            this.Hide();
            mydataWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btnMyhistory_Click(object sender, RoutedEventArgs e)
        {
            MyhistoryWindow myhistoryWindow = new MyhistoryWindow();
            this.Hide();
            myhistoryWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btnGetservice_Click(object sender, RoutedEventArgs e)
        {
            GetServiceWindow getServiceWindow = new GetServiceWindow();
            this.Hide();
            getServiceWindow.ShowDialog();
            this.ShowDialog();

        }

        private void btnFutureServices_Click(object sender, RoutedEventArgs e)
        {
            FutureServices futureServices=new FutureServices();
            this.Hide();
            futureServices.ShowDialog();
            this.ShowDialog();
        }
    }
}
