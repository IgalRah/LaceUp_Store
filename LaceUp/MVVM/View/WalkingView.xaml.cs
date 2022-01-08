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
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (19, 'Run Flyknit 2',250) " +
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

        private void ZoomPegasus38(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (20, 'Zoom Pegasus 38',170) " +
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

        private void PegasusTrail3(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (21, 'Pegasus Trail 3',189) " +
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

        private void ReactMiler(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (22, 'React Miler',100) " +
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

        private void ZoomPegasus40(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (23, 'Zoom Pegasus 40',200) " +
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

        private void ZoomStructure23(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = $"SET IDENTITY_INSERT [ShoppingBag] ON " +
                        " insert into [ShoppingBag](Id, Shoe,Price) values (24, 'Zoom Structure 23',110) " +
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
