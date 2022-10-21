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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Books.xaml
    /// </summary>
    public partial class Books : Window
    {
        public Books()
        {
            InitializeComponent();
        }

        

        private void btn_add_book_Click(object sender, RoutedEventArgs e)
        {
            Add_Book add_book = new Add_Book();
            add_book.Show();
        }

        private void btn_books_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "server=localhost;user id=root;database=library";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(mycon);
            MySqlCommand cmd = new MySqlCommand("select * from book ", con);
            DataTable dt = new DataTable();
            con.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dg_book.ItemsSource = dt.DefaultView;
        }

        private void btn_delete_book_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "server=localhost;user id=root;database=library";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(mycon);
            MySqlCommand cmd = new MySqlCommand("select * from book ", con);
            DataTable dt = new DataTable();
            con.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dg_book.ItemsSource = dt.DefaultView;
        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {
            string book;
            book = tbx_search.Text;
            string mycon = "server=localhost;user id=root;database=library";
            string query = "delete from book where Serial_Number ='" + book + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;
            MessageBox.Show("Remove staff Successfully.");
            con.Open();
            reader = com.ExecuteReader();
            con.Close();
        }
    }
}
