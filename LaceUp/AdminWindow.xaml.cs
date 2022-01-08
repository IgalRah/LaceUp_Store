using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace LaceUp
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public AdminWindow()
        {
            InitializeComponent();
            binddatagrid();

        }
        private void binddatagrid()
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strCon;
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Users]";
            cmd.Connection = sqlCon;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Users");

            da.Fill(dt);
            g1.ItemsSource = dt.DefaultView;

            sqlCon.Close();
        }
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Close_button(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void deleteButton(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = strCon;
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"Delete from [Users] WHERE UserID = {deleteBox.Text}";
                cmd.Connection = sqlCon;

                deleteBox.Clear();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Users");

                da.Fill(dt);
                g1.ItemsSource = dt.DefaultView;

                cmd.CommandText = "select * from [Users]";
                cmd.Connection = sqlCon;

                da.Fill(dt);
                g1.ItemsSource = dt.DefaultView;

                sqlCon.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
