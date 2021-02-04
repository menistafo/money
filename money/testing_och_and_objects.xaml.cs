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
    /// Логика взаимодействия для testing_och_and_objects.xaml
    /// </summary>
    public partial class testing_och_and_objects : UserControl
    {
        public testing_och_and_objects()
        {
            InitializeComponent();
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
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1YQoX6N71hwdF-sTaxMN5ASQCntBQUJtDmKYxheM7AsE/edit#gid=0");
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            objects.Children.Clear();
            objects.Children.Add(new testing_bugs());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            objects.Children.Clear();
            objects.Children.Add(new testing_och_preconditions());
        }
    }
}
