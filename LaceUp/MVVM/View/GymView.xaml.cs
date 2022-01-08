using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace LaceUp.MVVM.View
{
    /// <summary>
    /// Interaction logic for GymView.xaml
    /// </summary>
    public partial class GymView : UserControl
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public GymView()
        {
            InitializeComponent();
        }

        private void Romaleos4(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (7, 'Romaleos 4',250) " +
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

        private void Romaleos5(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (8, 'Romaleos 5',275) " +
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

        private void FreeMetcon4(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (9, 'Free Metcon 4',175) " +
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

        private void SuperRepGo2(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (10, 'SuperRep Go 2',200) " +
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

        private void BellaTR4Premium(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (11, 'Bella TR 4 Premium 4',150) " +
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

        private void DefyAllDay(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (12, 'Defy All Day',125) " +
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
