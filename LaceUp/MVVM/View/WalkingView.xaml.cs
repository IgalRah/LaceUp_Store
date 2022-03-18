using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace LaceUp.MVVM.View
{
    /// <summary>
    /// Interaction logic for WalkingView.xaml
    /// </summary>
    public partial class WalkingView : UserControl
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public WalkingView()
        {
            InitializeComponent();
        }

        private void RunFlyknit2(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Run Flyknit 2'";
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

        private void ZoomPegasus38(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Zoom Pegasus 38'";
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

        private void PegasusTrail3(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Pegasus Trail 3'";
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

        private void ReactMiler(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'React Miler'";
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

        private void ZoomPegasus40(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Zoom Pegasus 40'";
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

        private void ZoomStructure23(object sender, RoutedEventArgs e)
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
                                       " WHERE ShoeName = 'Zoom Structure 23'";
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
