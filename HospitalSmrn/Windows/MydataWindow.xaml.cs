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
using HospitalSmrn.EF;

namespace HospitalSmrn.Windows
{
    /// <summary>
    /// Логика взаимодействия для MydataWindow.xaml
    /// </summary>
    public partial class MydataWindow : Window
    {
        public MydataWindow()
        {
            InitializeComponent();
            tbFIO.Text =ClassHelper.DataTransmission.GetClient.FullName;
            tbAdress.Text = ClassHelper.DataTransmission.GetClient.Address;
            tbBirthday.Text = ClassHelper.DataTransmission.GetClient.DateOfBirthday.ToString();
            tbGender.Text = ClassHelper.DataTransmission.GetClient.GenderYuliya.GenderName;
            tbMail.Text = ClassHelper.DataTransmission.GetClient.Email;
            tbPhone.Text = ClassHelper.DataTransmission.GetClient.Phone;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            btnChangeSave.Content = "Изменить";
        }

        private void btnChangeSave_Click(object sender, RoutedEventArgs e)
        {
            if (btnChangeSave.Content.ToString() == "Изменить")
            {
                btnChangeSave.Content = "Сохранить";
                tbxAdress.Visibility = Visibility.Visible;
                tbxBirthday.Visibility = Visibility.Visible;
                tbxFIO.Visibility = Visibility.Visible;
                tbxMail.Visibility = Visibility.Visible;
                tbxPhone.Visibility = Visibility.Visible;

                tbxAdress.Text = HospitalSmrn.ClassHelper.DataTransmission.GetClient.Address;
                tbxBirthday.Text = HospitalSmrn.ClassHelper.DataTransmission.GetClient.DateOfBirthday.ToString() ;
                tbxFIO.Text = HospitalSmrn.ClassHelper.DataTransmission.GetClient.FullName;
                tbxMail.Text = HospitalSmrn.ClassHelper.DataTransmission.GetClient.Email;
                tbxPhone.Text = HospitalSmrn.ClassHelper.DataTransmission.GetClient.Phone;
            }
            else 
            {
                string[] nameParts = tbxFIO.Text.Split(' ');
                if(nameParts.Length < 3) {
                    MessageBox.Show("ФИО введено некорректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if(DateTime.TryParse(tbxBirthday.Text, out DateTime date)==false)
                {
                    MessageBox.Show("Дата рождения введена некорректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                btnChangeSave.Content = "Изменить";
                tbxAdress.Visibility = Visibility.Collapsed;
                tbxBirthday.Visibility = Visibility.Collapsed;
                tbxFIO.Visibility = Visibility.Collapsed;
                tbxMail.Visibility = Visibility.Collapsed;
                tbxPhone.Visibility = Visibility.Collapsed;
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.Address = tbAdress.Text;             
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.FName = nameParts[0];
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.LName = nameParts[1];
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.MName = nameParts[2];
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.Address = tbxAdress.Text;
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.Phone = tbxPhone.Text;
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.DateOfBirthday = Convert.ToDateTime(tbxBirthday.Text);
                HospitalSmrn.ClassHelper.DataTransmission.GetClient.Email = tbxMail.Text;
                ClassHelper.AppData.Context.SaveChanges();
                btnChangeSave.Content = "Изменить";
                MessageBox.Show("Клиент изменен");
                this.Close();
            }
            
        }
    }
}
