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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void tbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "Логин")
            {
                tbLogin.Text = "";
                tbLogin.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void tbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text) || tbLogin.Text == "Логин")
            {
                tbLogin.Text = "Логин";
                tbLogin.Foreground = new SolidColorBrush(Colors.LightGray);
            }
        }

        private void tbPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            tbPassword.Visibility = Visibility.Collapsed;
            pbPass.Focus(); // Передаем фокус на textBox2
            e.Handled = true;
        }

        private void pbPass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pbPass.Password=="")
            {
                tbPassword.Visibility=Visibility.Visible;
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var authUser = ClassHelper.AppData.Context.PatientYuliya.ToList().
                Where(i => i.Login == tbLogin.Text && i.Password == pbPass.Password).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("Введите логин!");
            }
            else if (string.IsNullOrWhiteSpace(pbPass.Password))
            {
                MessageBox.Show("Введите пароль!");
            }
            else if (authUser != null)
            {
                DataTransmission.GetClient = authUser;
                ClassHelper.AppData.Context.SaveChanges();
                PatientWindow patientWindow = new PatientWindow();
                this.Hide();
                patientWindow.ShowDialog();
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbPassword.Visibility = Visibility.Visible;
            pbPass.Password = "";
            tbLogin.Text = "Логин";
            tbLogin.Foreground = new SolidColorBrush(Colors.LightGray);
            RegistrationWindow registrationWindow = new RegistrationWindow();
            this.Hide();
            registrationWindow.ShowDialog();
            this.ShowDialog();
        }
    }
}
