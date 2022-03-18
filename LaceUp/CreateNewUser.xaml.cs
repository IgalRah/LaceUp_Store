using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;

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
                    else if (!EmailBox.Text.Contains("@")) //Check if EmailBox contains '@'
                    {
                        MessageBox.Show("Invalid mail");
                        EmailBox.Clear();
                    }
                    else if (string.IsNullOrWhiteSpace(userNameBox.Text)) //Check if userNameBox is empty
                    {
                        MessageBox.Show("User name is required");
                    }
                    else if (string.IsNullOrWhiteSpace(passwordBox.Password.ToString())) //Check if passwordBox is empty
                    {
                        MessageBox.Show("Password is required");
                    }
                    else
                    {
                        String query = "SELECT COUNT(1) FROM Users WHERE UserName=@UserName"; 

                        SqlCommand sqlCmdommand = new(query, sqlCon);
                        sqlCmdommand.CommandType = CommandType.Text;
                        sqlCmdommand.Parameters.AddWithValue("@UserName", userNameBox.Text);

                        int count = Convert.ToInt32(sqlCmdommand.ExecuteScalar());

                        var input = passwordBox.Password;
                        var hasNumber = new Regex(@"[0-9]+");
                        var hasUpperChar = new Regex(@"[A-Z]+");

                        if (1 <= count) // Check if User exist
                        {
                            MessageBox.Show("user name is already taken");
                        }
                        else if (hasNumber.IsMatch(input) != true || hasUpperChar.IsMatch(input) != true) // Check if password contains CL and Symbol
                        {
                            MessageBox.Show("Password must contain Capital letter and at least one number");
                            passwordBox.Clear();
                        }
                        else if (passwordBox.Password.Length <= 6) // Check password length
                        {
                            MessageBox.Show("Password must be at least 6 characters");
                            passwordBox.Clear();
                        }
                        else
                        {
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("User creation was successful,\nWelcome to the family!");

                            Close();
                        }
                    }

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
    }
}
