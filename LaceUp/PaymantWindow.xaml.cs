using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace LaceUp
{
    /// <summary>
    /// Interaction logic for PaymantWindow.xaml
    /// </summary>
    public partial class PaymantWindow : Window
    {
        private readonly string strCon = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public PaymantWindow()
        {
            InitializeComponent();
            binddatagrid();
        }

        private void binddatagrid()
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strCon;
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [ShoppingBag]";
            cmd.Connection = sqlCon;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ShoppingBag");

            da.Fill(dt);
            g1.ItemsSource = dt.DefaultView;

            sqlCon.Close();
        }

        private void payButton(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Thank you for choosing LaceUp!");

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strCon;
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete FROM ShoppingBag";
            cmd.Connection = sqlCon;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ShoppingBag");

            da.Fill(dt);

            g1.ItemsSource = dt.DefaultView;

            Close();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ContinueshoppingButton(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = strCon;
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"Delete from [ShoppingBag] WHERE Id = {deleteBox.Text}";
                cmd.Connection = sqlCon;

                deleteBox.Clear();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ShoppingBag");

                da.Fill(dt);
                g1.ItemsSource = dt.DefaultView;

                cmd.CommandText = "select * from [ShoppingBag]";
                cmd.Connection = sqlCon;

                da.Fill(dt);
                g1.ItemsSource = dt.DefaultView;

                sqlCon.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
