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
    /// Interaction logic for Members.xaml
    /// </summary>
    public partial class Members : Window
    {
        public Members()
        {
            InitializeComponent();
        }
        private void btn_members_list_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "server=localhost;user id=root;database=library";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(mycon);
            MySqlCommand cmd = new MySqlCommand("select * from member", con);
            DataTable dt = new DataTable();
            con.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dg_member.ItemsSource = dt.DefaultView;
        }
    }
}
