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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Max Aura 3'";
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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Air Jordan 1 Mid'";
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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Air Jordan 1 Acclimate'";
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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Jordan Delta 2'";
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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                        " SELECT ShoeName, ShoePrice" +
                                        " FROM ShoeInffo" +
                                        " WHERE ShoeName = 'Zion 1'";
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
                    sqlCmd.CommandText = "INSERT INTO ShoppingBag(Shoe,Price)" +
                                       " SELECT ShoeName, ShoePrice" +
                                       " FROM ShoeInffo" +
                                       " WHERE ShoeName = 'Air Jordan 1 Mid'";
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
