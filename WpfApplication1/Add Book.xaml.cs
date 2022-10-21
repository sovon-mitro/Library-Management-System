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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Add_Book.xaml
    /// </summary>
    public partial class Add_Book : Window
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void clear()
        {
            Txb_Serial_Number.Clear();
            txb_Title.Clear();
            Txb_Subject.Clear();
            Txb_Category.Clear();
            Txb_Author.Clear();
            Txb_Publisher.Clear();
            Txb_Note.Clear();
        }
        private void button_Add_Book_Click(object sender, RoutedEventArgs e)
        {
            string Serial_Number, Book_Title, Subject, Category, Author, Publisher, Note;
            Serial_Number = Txb_Serial_Number.Text;
            Book_Title = txb_Title.Text;
            Subject = Txb_Subject.Text;
            Category = Txb_Category.Text;
            Author = Txb_Author.Text;
            Publisher = Txb_Publisher.Text;
            Note = Txb_Note.Text;
            string mycon = "server=localhost;user id=root;database=library";
            string query = "insert into book (Serial_Number, Book_Title, Subject, Category, Author, Publisher,Note) values('" + Serial_Number + "', '" + Book_Title + "', '" + Subject + "', '" + Category + "', '" + Author + "', '" + Publisher + "', '" + Note + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            con.Close();
            MessageBox.Show("Info. Inserted Successfully...");
            clear();
        }
    }
}
