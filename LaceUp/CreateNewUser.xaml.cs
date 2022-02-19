using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace LaceUp
{
    /// <summary>
    /// Interaction logic for CreateNewUser.xaml
    /// </summary>
    public partial class CreateNewUser : Window
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void Grid_MouseSecond(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new()
                    {
                        Connection = sqlCon,
                        CommandText = "Insert into Users(Email,Username,Password) values (@EmailBox,@UserName,@Password)",
                        CommandType = CommandType.Text
                    };

                    sqlCmd.Parameters.AddWithValue("@EmailBox", EmailBox.Text);
                    sqlCmd.Parameters.AddWithValue("@UserName", userNameBox.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", passwordBox.Password);


                    SqlParameter outPutParam = new()
                    {
                        ParameterName = "@Id",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    sqlCmd.Parameters.Add(outPutParam);


                    if (string.IsNullOrWhiteSpace(userNameBox.Text) && string.IsNullOrWhiteSpace(passwordBox.ToString()) && string.IsNullOrWhiteSpace(EmailBox.Text))
                    {
                        MessageBox.Show("User name and password are required!");
                    }

                    else if (!EmailBox.Text.Contains("@"))
                    {
                        MessageBox.Show("Invalid mail");
                    }

                    else if ( 
                        !passwordBox.Password.Contains("!") && 
                        !passwordBox.Password.Contains("@") &&
                        !passwordBox.Password.Contains("#") &&
                        !passwordBox.Password.Contains("$") &&
                        !passwordBox.Password.Contains("%") &&
                        !passwordBox.Password.Contains("^") &&
                        !passwordBox.Password.Contains("&") &&
                        !passwordBox.Password.Contains("*") &&
                        !passwordBox.Password.Contains("(") &&
                        !passwordBox.Password.Contains(")") &&
                        !passwordBox.Password.Contains("_") &&
                        !passwordBox.Password.Contains("+"))
                    {
                        MessageBox.Show("Invalid password");
                    }

                    else if (string.IsNullOrWhiteSpace(userNameBox.Text))
                    {
                        MessageBox.Show("User name is required");
                    }

                    else if (string.IsNullOrWhiteSpace(passwordBox.ToString()))
                    {
                        MessageBox.Show("Password is required");
                    }

                    else
                    {
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("User creation was successful,\nWelcome to the family!");

                        Close();
                    }

                    EmailBox.Clear();
                    userNameBox.Clear();
                    passwordBox.Clear();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void facebookButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Currently unavailable");
        }

        private void googleButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Currently unavailable");
        }
    }
}
