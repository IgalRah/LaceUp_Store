using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace LaceUp.MVVM.View
{
    /// <summary>
    /// Interaction logic for LifeStyle.xaml
    /// </summary>
    public partial class LifeStyle : UserControl
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public LifeStyle()
        {
            InitializeComponent();
        }

        private void blazerMidButton(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Blazer Mid `77'";
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

        private void airPrestoPremiumButton(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Air Presto Premium'";
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

        private void alazerLow77Button(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Blazer Low `77'";
                    sqlCmd.Connection = sqlCon;
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

        private void airForce1MidJewelButton(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Air Force 1 Mid Jewel'";
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

        private void blazerMid77Button(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Blazer Mid `77'";
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

        private void wAirForce1HighSculptButton(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Air Force 1 High Sculpt'";
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
