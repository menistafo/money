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
    /// Логика взаимодействия для testing_pak_1.xaml
    /// </summary>
    public partial class testing_pak_1 : UserControl
    {
        public testing_pak_1()
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
            System.Diagnostics.Process.Start("https://fk.jira.lanit.ru/browse/FCS-148479");
        }

        private void hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/11fWHEBDjHErgr4uDcOCte-s_0PshmHUmn33zHlHQ9UY/edit#gid=1668127965");
        }

        private void hyperlink_2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1GM_bO0tAxutWaVm7pKMfM0KWrElauDbf");
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            pak_1.Children.Clear();
            pak_1.Children.Add(new testing_pak_2());
        }
    }
}
