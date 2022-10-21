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
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for admin_login.xaml
    /// </summary>
    public partial class admin_login : Window
    {
        public admin_login()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txb_admin_username.Clear();
            pbx_admin_password.Clear();
        }

        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            string username = txb_admin_username.Text;
            string password = pbx_admin_password.Password;
            if ((username == "20201043010" && password == "NWU") || (username == "20201170010" && password == "NWU"))
            {
                Dashborad md = new Dashborad();
                md.Show();
                clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password.Please Enter correctly");
                clear();
            }
        }
    }
}
