using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для testing_mp_2.xaml
    /// </summary>
    public partial class testing_mp_2 : UserControl
    {
        public testing_mp_2()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            mp_2.Children.Clear();
            mp_2.Children.Add(new testing_mp_1());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            mp_2.Children.Clear();
            mp_2.Children.Add(new testing_mp_3());
        }

        private void Application_NavigationFailed(object sender,
       System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            if (e.Exception is System.Net.WebException)
            {
                MessageBox.Show("Сайт " + e.Uri.ToString() + " не доступен :(");
                // Нейтрализовать ошибку, чтобы приложение продолжило свою работу
                e.Handled = true;
            }
        }

        private void hyperlink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1Mc0BjiB9DbIYhxLCyaH2lJ-Sn5ZxxncVm45s6ohzUnk/edit#gid=1384984347");
        }
    }
}
