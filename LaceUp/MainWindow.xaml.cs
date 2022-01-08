using System;
using System.Windows;
using System.Windows.Input;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LaceUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new(strCon);
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                String query = "SELECT COUNT(1) FROM Users WHERE UserName=@UserName AND Password=@Password";

                SqlCommand sqlCmd = new(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@UserName", usernameInput.Text);
                sqlCmd.Parameters.AddWithValue("@Password", passwordInput.Password);

                usernameInput.Clear();
                passwordInput.Clear();

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MenuScreen menuScreen = new();
                    menuScreen.Show();

                    Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void CreateNewUserButton(object sender, RoutedEventArgs e)
        {
            CreateNewUser createNewUser = new();
            createNewUser.Show();
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LoginAdminButton(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new(strCon);
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                String query = "SELECT COUNT(1) FROM Users WHERE UserName=@Igal AND Password=@1998";

                SqlCommand sqlCmd = new(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@Igal", usernameInput.Text);
                sqlCmd.Parameters.AddWithValue("@1998", passwordInput.Password);

                usernameInput.Clear();
                passwordInput.Clear();

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    AdminWindow adminWindow = new();
                    adminWindow.Show();
                }
                else
                {
                    MessageBox.Show("Invalid data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
