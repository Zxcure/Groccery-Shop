using System;
using Groccery_Shop.ClassHelper;
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

namespace Groccery_Shop
{
    public partial class Registration : Window
    {
        public object ClassHelper { get; private set; }

        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBLastName.Text))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBFirstName.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPhone.Text))
            {
                MessageBox.Show("Поле Телефон не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBEmail.Text))
            {
                MessageBox.Show("Поле Почта не заполнено");
            }
            if (string.IsNullOrWhiteSpace(TBLogin.Text))
            {
                MessageBox.Show("Заполните логин");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                MessageBox.Show("Заполните пароль");
                return;
            }

            DB.Client addClient = new DB.Client();
            
            
            addClient.LastName = TBLastName.Text;
            addClient.FirstName = TBFirstName.Text;
            addClient.Email = TBEmail.Text;
            addClient.Phone = TBPhone.Text;
            addClient.Login = TBLogin.Text;
            addClient.Password = TBPassword.Text;

            EFCL.Context.Client.Add(addClient);
            EFCL.Context.SaveChanges();
            MessageBox.Show("Пользоваталь успешно добавлен");
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Autorization authWindow = new Autorization();
            authWindow.Show();
        }

        private void TBLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            TBLastName.Text = "";
        }

        private void TBFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            TBFirstName.Text = "";  
        }

        private void TBPhone_GotFocus(object sender, RoutedEventArgs e)
        {
            TBPhone.Text = "";
        }

        private void TBEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TBEmail.Text = "";
        }

        private void TBLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            TBLogin.Text = "";
        }

        private void TBPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            TBPassword.Text = "";
        }
    }
}
