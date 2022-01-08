using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace LaceUp.MVVM.View
{
    /// <summary>
    /// Interaction logic for JordanView.xaml
    /// </summary>
    public partial class JordanView : UserControl
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public JordanView()
        {
            InitializeComponent();
        }

        private void MaxAura3(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (13, 'Max Aura 3',230) " +
                        " SET IDENTITY_INSERT [ShoppingBag] OFF";

                    sqlCmd.Connection = sqlCon;

                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Added to bag!");
                }
            }
            catch
            {
                MessageBox.Show("Item already in your inventory");
            }
        }

        private void AirJordan1Mid(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (14, 'Air Jordan 1 Mid',300) " +
                        " SET IDENTITY_INSERT [ShoppingBag] OFF";

                    sqlCmd.Connection = sqlCon;

                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Added to bag!");
                }
            }
            catch
            {
                MessageBox.Show("Item already in your inventory");
            }
        }

        private void AirJordan1Acclimate(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (15, 'Air Jordan 1 Acclimate',275) " +
                        " SET IDENTITY_INSERT [ShoppingBag] OFF";

                    sqlCmd.Connection = sqlCon;

                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Added to bag!");
                }
            }
            catch
            {
                MessageBox.Show("Item already in your inventory");
            }
        }

        private void JordanDelta2(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (16, 'Jordan Delta 2',250) " +
                        " SET IDENTITY_INSERT [ShoppingBag] OFF";

                    sqlCmd.Connection = sqlCon;

                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Added to bag!");
                }
            }
            catch
            {
                MessageBox.Show("Item already in your inventory");
            }
        }

        private void Zion1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (17, 'Zion 1',175) " +
                        " SET IDENTITY_INSERT [ShoppingBag] OFF";

                    sqlCmd.Connection = sqlCon;

                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Added to bag!");
                }
            }
            catch
            {
                MessageBox.Show("Item already in your inventory");
            }
        }

        private void AirJordan1Mid2(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (18, 'Air Jordan 1 Mid',200) " +
                        " SET IDENTITY_INSERT [ShoppingBag] OFF";

                    sqlCmd.Connection = sqlCon;

                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Added to bag!");
                }
            }
            catch
            {
                MessageBox.Show("Item already in your inventory");
            }
        }
    }
}
