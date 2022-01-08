using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace LaceUp
{
    /// <summary>
    /// Interaction logic for MenuScreen.xaml
    /// </summary>
    public partial class MenuScreen : Window
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void GridMouseMove_MenuScreen(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void shoppingBagButton(object sender, RoutedEventArgs e)
        {
            PaymantWindow paymant = new PaymantWindow();

            paymant.Show();
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strCon;
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete FROM ShoppingBag";
            cmd.Connection = sqlCon;

            DataTable dt = new DataTable("ShoppingBag");
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            Close();
        }

        private void logOutButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Close();
        }
    }
}
