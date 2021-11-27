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

namespace DbProject
{
    /// <summary>
    /// Логика взаимодействия для LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        DataClass db = new DataClass();
        public LoginForm()
        {
            InitializeComponent();
            tbLoginUser.Focus();
            db.CreateStrConnection();
        }

        private void btnLoginUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int answer = db.Authorize(tbLoginUser.Text, tbPassUser.Password);
                if(answer > 0)
                {
                    MessageBox.Show("Авторизация прошла успешно!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Авторизация не удалась", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoginGuest_Click(object sender, RoutedEventArgs e)
        {
            WindowGuest windowGuest = new WindowGuest();
            windowGuest.Show();
            this.Hide();
        }


        private void tbLoginUser_TouchEnter(object sender, TouchEventArgs e)
        {
        }

        private void tbLoginUser_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                tbPassUser.Focus();
            }
        }

        private void tbPassUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLoginUser_Click(null,null);
            }
        }

    }
}
