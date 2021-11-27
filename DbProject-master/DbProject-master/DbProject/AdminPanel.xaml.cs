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
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        DataClass db = new DataClass();
        public AdminPanel()
        {
            InitializeComponent();
            db.CreateStrConnection();

            
        }

        private void btnGoBookAdmin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void btnGoUserAdmin_Click(object sender, RoutedEventArgs e)
        {
            UserEdit userEdit = new UserEdit();
            userEdit.Show();
        }
    }
}
