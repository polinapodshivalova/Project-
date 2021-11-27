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
    /// Логика взаимодействия для UserEdit.xaml
    /// </summary>
    public partial class UserEdit : Window
    {
        DataClass db = new DataClass();
        Users user = new Users();
        int idUser;
        public UserEdit()
        {
            InitializeComponent();
            db.CreateStrConnection();
            dgUsers.ItemsSource = db.ReadUser();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            db.AddUser(tbUserLogin.Text, tbUserPass.Text, tbLastName.Text, tbFirstName.Text);
           dgUsers.ItemsSource = db.ReadUser();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            db.UpdUser(idUser,tbUserLogin.Text,tbUserPass.Text,tbLastName.Text,tbFirstName.Text);
            dgUsers.ItemsSource = db.ReadUser();
        }

        private void btnDelate_Click(object sender, RoutedEventArgs e)
        {
            db.DelUser(idUser);
            dgUsers.ItemsSource = db.ReadUser();
        }

        private void dgUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Users user = new Users();
            user = dgUsers.SelectedItem as Users;
            if (user != null)
            {
                tbUserLogin.Text = user.login;
                tbUserPass.Text = user.password;
                tbLastName.Text = user.LastName;
                tbFirstName.Text = user.FirstName;
                idUser = user.idUser;
            }
        }

    }
}
