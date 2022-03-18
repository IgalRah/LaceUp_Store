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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Romaleos 4'";

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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Romaleos 5'";

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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Free Metcon 4'";

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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'SuperRep Go 2'";
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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Bella TR 4 Premium 4'";
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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Defy All Day'";

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
