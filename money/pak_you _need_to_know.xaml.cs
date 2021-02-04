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
    /// Логика взаимодействия для pak_you__need_to_know.xaml
    /// </summary>
    public partial class pak_you__need_to_know : UserControl
    {
        public pak_you__need_to_know()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            pak_ebz.Children.Clear();
            pak_ebz.Children.Add(new sert_akimov());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            pak_ebz.Children.Clear();
            pak_ebz.Children.Add(new autotest_och());
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
            System.Diagnostics.Process.Start("https://fk.jira.lanit.ru/browse/FCSSUPP-51657");
        }
    }
}
