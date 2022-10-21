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
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Member_List.xaml
    /// </summary>
    public partial class Member_List : Window
    {
        public Member_List()
        {
            InitializeComponent();
        }

        private void bt_show_list_Click(object sender, RoutedEventArgs e)
        {
            string show;
            show = tb_member_list.Text;
            string mycon = "server=localhost;user id=root;database=library";
            string query = "insert into member where name = '" + tb_member_list.Text + "' (name)values('" + tb_member_list.Text + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();
            con.Close();
            MessageBox.Show("info,Inserted Successfully...");
        }

        
       
    }
}

