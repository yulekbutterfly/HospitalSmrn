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
    /// Логика взаимодействия для GetServiceWindow.xaml
    /// </summary>
    public partial class GetServiceWindow : Window
    {
        public GetServiceWindow()
        {
            InitializeComponent();
            lvService.ItemsSource= ClassHelper.AppData.Context.MedicalServiceYuliya.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();    
        }

        private void btnGetService_Click(object sender, RoutedEventArgs e)
        {
            if (dpChooseDate.SelectedDate == null || dpChooseDate.SelectedDate < DateTime.Now)
            {
                MessageBox.Show("Поле ДАТА заполненно некорректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var service = lvService.SelectedItem as EF.MedicalServiceYuliya;
            if (service != null)
            {
                EF.AppointmentYuliya appointmentYuliya= new EF.AppointmentYuliya();
                appointmentYuliya.IDEmployee = 1;
                appointmentYuliya.IDMedicalService = service.ID;
                appointmentYuliya.DateService= Convert.ToDateTime(dpChooseDate.SelectedDate);
                appointmentYuliya.IDPatient = ClassHelper.DataTransmission.GetClient.ID;
                ClassHelper.AppData.Context.AppointmentYuliya.Add(appointmentYuliya);
                ClassHelper.AppData.Context.SaveChanges();
                MessageBox.Show("Услуга добавлена");
                this.Close();
            }
        }
    }
}
