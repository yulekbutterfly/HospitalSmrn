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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void tb_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;          
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name=="tbLogin")
            {
                textBox.Text = "Логин";
                textBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name == "tbFirstName")
            {
                textBox.Text = "Имя";
                textBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name == "tbSurname")
            {
                textBox.Text = "Фамилия";
                textBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name == "tbMiddleName")
            {
                textBox.Text = "Отчество";
                textBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name == "tbAdress")
            {
                textBox.Text = "Адрес";
                textBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name == "tbPhone")
            {
                textBox.Text = "Телефон";
                textBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name == "tbEmail")
            {
                textBox.Text = "Почта";
                textBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
            //tbEmail tbPhone tbAdress tbMiddleName tbFirstName 

        }
        private void tb_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Логин" && textBox.Name == "tbLogin")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (textBox.Text == "Имя" && textBox.Name == "tbFirstName")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (textBox.Text == "Фамилия" && textBox.Name == "tbSurname")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (textBox.Text == "Отчество" && textBox.Name == "tbMiddleName")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (textBox.Text == "Адрес" && textBox.Name == "tbAdress")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (textBox.Text == "Телефон" && textBox.Name == "tbPhone")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (textBox.Text == "Почта" && textBox.Name == "tbEmail")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
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
            if (pbPass.Password == "")
            {
                tbPassword.Visibility = Visibility.Visible;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                MessageBox.Show("Поле ИМЯ не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbMiddleName.Text))
            {
                MessageBox.Show("Поле ФАМИЛИЯ не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                MessageBox.Show("Поле ОТЧЕСТВО не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Поле ТЕЛЕФОН не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (dpBirthday.SelectedDate == null)
            {
                MessageBox.Show("Поле ДАТА РОЖДЕНИЯ не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbAdress.Text))
            {
                MessageBox.Show("Поле Адрес не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("Поле Логин не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ckFem.IsChecked==false &&ckMale.IsChecked==false)
            {
                MessageBox.Show("Пол должен быть выбран!!!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                var resClick = MessageBox.Show("Добавить пользователя", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (resClick == MessageBoxResult.No)
                {
                    return;
                }

                EF.PatientYuliya patientYuliya = new EF.PatientYuliya();
                patientYuliya.FName = tbFirstName.Text;
                patientYuliya.LName = tbSurname.Text;
                patientYuliya.MName = tbMiddleName.Text;
                patientYuliya.Address = tbAdress.Text;
                patientYuliya.Phone = tbPhone.Text;
                patientYuliya.DateOfBirthday = Convert.ToDateTime(dpBirthday.SelectedDate);
                patientYuliya.Email = tbEmail.Text;
                patientYuliya.Login = tbLogin.Text;
                patientYuliya.Password = pbPass.Password;
                if (ckFem.IsChecked == false)
                {
                    patientYuliya.IDGender = 2;
                }
                else
                {
                    patientYuliya.IDGender = 1;
                }
                ClassHelper.AppData.Context.PatientYuliya.Add(patientYuliya);
                ClassHelper.AppData.Context.SaveChanges();
                MessageBox.Show("Клиент добавлен");
                this.Close();
            }            

        }

        private void ckMale_Checked(object sender, RoutedEventArgs e)
        {
            ckFem.IsChecked = false;
        }

        private void ckFem_Checked(object sender, RoutedEventArgs e)
        {
            ckMale.IsChecked = false;
        }
    }
}
