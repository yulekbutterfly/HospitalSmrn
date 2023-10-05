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

namespace HospitalSmrn.Windows
{
    /// <summary>
    /// Логика взаимодействия для FutureServices.xaml
    /// </summary>
    public partial class FutureServices : Window
    {
        public FutureServices()
        {
            InitializeComponent();
            lvFutureService.ItemsSource= ClassHelper.AppData.Context.AppointmentYuliya.Where(i => i.DateService>=DateTime.Now).ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
