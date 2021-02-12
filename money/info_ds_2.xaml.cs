using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace money
{
    /// <summary>
    /// Логика взаимодействия для info_ds_2.xaml
    /// </summary>
    public partial class info_ds_2 : UserControl
    {
        public info_ds_2()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            info_ds2.Children.Clear();
            info_ds2.Children.Add(new info_ds_3());
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SUPPORT_1;Initial Catalog=test_programm;Integrated Security=True");

            sqlConnection.Open(); // открываем базу данных


            string a = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_1'");
            SqlCommand cmd = new SqlCommand(a, sqlConnection); // создаём запрос
            SqlDataReader reader = cmd.ExecuteReader(); // получаем данные
            while (reader.Read())
            {
                textBlock1.Text = reader.GetValue(0).ToString();
            }
            reader.Close();

            string b = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_2'");
            SqlCommand cmd2 = new SqlCommand(b, sqlConnection); // создаём запрос
            SqlDataReader reader2 = cmd2.ExecuteReader(); // получаем данные
            while (reader2.Read())
            {
                textBlock2.Text = reader2.GetValue(0).ToString();
            }
            reader2.Close();

            string c = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_3'");
            SqlCommand cmd3 = new SqlCommand(c, sqlConnection); // создаём запрос
            SqlDataReader reader3 = cmd3.ExecuteReader(); // получаем данные
            while (reader3.Read())
            {
                textBlock3.Text = reader3.GetValue(0).ToString();
            }
            reader3.Close();

            string d = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_4'");
            SqlCommand cmd4 = new SqlCommand(d, sqlConnection); // создаём запрос
            SqlDataReader reader4 = cmd4.ExecuteReader(); // получаем данные
            while (reader4.Read())
            {
                textBlock4.Text = reader4.GetValue(0).ToString();
            }
            reader4.Close();
            string e1 = String.
                Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_5'");
            SqlCommand cmd5 = new SqlCommand(e1, sqlConnection); // создаём запрос
            SqlDataReader reader5 = cmd5.ExecuteReader(); // получаем данные
            while (reader5.Read())
            {
                textBlock5.Text = reader5.GetValue(0).ToString();
            }
            reader5.Close();

            string f = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_6'");
            SqlCommand cmd6 = new SqlCommand(f, sqlConnection); // создаём запрос
            SqlDataReader reader6 = cmd6.ExecuteReader(); // получаем данные
            while (reader6.Read())
            {
                textBlock6.Text = reader6.GetValue(0).ToString();
            }
            reader6.Close();

            string g = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_7'");
            SqlCommand cmd7 = new SqlCommand(g, sqlConnection); // создаём запрос
            SqlDataReader reader7 = cmd7.ExecuteReader(); // получаем данные
            while (reader7.Read())
            {
                textBlock7.Text = reader7.GetValue(0).ToString();
            }
            reader7.Close();

            string h = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_8'");
            SqlCommand cmd8 = new SqlCommand(h, sqlConnection); // создаём запрос
            SqlDataReader reader8 = cmd8.ExecuteReader(); // получаем данные
            while (reader8.Read())
            {
                textBlock8.Text = reader8.GetValue(0).ToString();
            }
            reader8.Close();

            string i = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_9'");
            SqlCommand cmd9 = new SqlCommand(i, sqlConnection); // создаём запрос
            SqlDataReader reader9 = cmd9.ExecuteReader(); // получаем данные
            while (reader9.Read())
            {
                textBlock9.Text = reader9.GetValue(0).ToString();
            }
            reader9.Close();

            string j = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_2_10'");
            SqlCommand cmd10 = new SqlCommand(j, sqlConnection); // создаём запрос
            SqlDataReader reader10 = cmd10.ExecuteReader(); // получаем данные
            while (reader10.Read())
            {
                textBlock10.Text = reader10.GetValue(0).ToString();
            }
            reader10.Close();

            sqlConnection.Close();
        }
    }
}
