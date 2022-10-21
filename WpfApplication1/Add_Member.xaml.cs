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


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Add_Member.xaml
    /// </summary>
    public partial class Add_Member : Window
    {
        public Add_Member()
        {
            InitializeComponent();
        }

        private void bt_signup_click(object sender, RoutedEventArgs e)
        {
            string name, password, department, address, email, date;
            name = Txb_membername.Text;
            password = Txb_password.Text;
            department = Txb_dept.Text;
            email = Txb_email.Text;
            address = Txb_address.Text;
            date = Txb_date.Text;

            string mycon = "server=localhost;user id=root;database=library";
            string query = "insert into member (name, password, department, email, address,date) values('" + name + "', '" + password + "', '" + department + "', '" + email + "', '" + address + "', '" + date + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader =com.ExecuteReader();
            con.Close();
            MessageBox.Show("Info. Inserted Successfully...");
        }
    }
}
