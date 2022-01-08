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
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (1, 'Blazer Mid `77',150) " +
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

        private void airPrestoPremiumButton(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (2, 'Air Presto Premium',220) " +
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

        private void alazerLow77Button(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (3, 'Blazer Low `77',120) " +
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

        private void airForce1MidJewelButton(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (4, 'Air Force 1 Mid Jewel',250) " +
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

        private void blazerMid77Button(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (5, 'Blazer Mid `77',150) " +
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

        private void wAirForce1HighSculptButton(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (6, 'Air Force 1 High Sculpt',200) " +
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
