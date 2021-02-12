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
    /// Логика взаимодействия для info_ds_1.xaml
    /// </summary>
    public partial class info_ds_1 : UserControl
    {
        public info_ds_1()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SUPPORT_1;Initial Catalog=test_programm;Integrated Security=True");

            sqlConnection.Open(); // открываем базу данных


            string a = String.Format("SELECT description FROM Introductory_information WHERE id = 'info_ds_1'");
            SqlCommand cmd = new SqlCommand(a, sqlConnection); // создаём запрос
            SqlDataReader reader = cmd.ExecuteReader(); // получаем данные
            while (reader.Read())
            {
                textBlock2.Text = reader.GetValue(0).ToString();
            }
            //reader.Close();
           

            sqlConnection.Close();
        }
    }
}
