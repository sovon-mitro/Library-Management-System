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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;




namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txb_username.Clear();
            pbx_password.Clear();
        }

        

        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            string username = txb_username.Text;
            string password = pbx_password.Password;
            if((username == "20201043010" && password == "NWU")|| (username == "20201170010" && password == "NWU"))
            {
                member_dashborad md = new member_dashborad();
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

        private void bt_Sign_Up_Click(object sender, RoutedEventArgs e)
        {
            Add_Member Add = new Add_Member();
            Add.Show();
        }

        private void bt_Admin_Click(object sender, RoutedEventArgs e)
        {
            admin_login admin = new admin_login();
            admin.Show();
            this.Close();
        }
    }
}
