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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Dashborad.xaml
    /// </summary>
    public partial class Dashborad : Window
    {
        public Dashborad()
        {
            InitializeComponent();
        }

        private void btn_members_Click(object sender, RoutedEventArgs e)
        {
            Members Members = new Members();
            Members.Show();
        }

        private void btn_book_Click(object sender, RoutedEventArgs e)
        {
            Books book = new Books();
            book.Show();
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            admin_login admin = new admin_login();
            admin.Show();
        }
    }
}
