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
    /// Логика взаимодействия для testing_bugs.xaml
    /// </summary>
    public partial class testing_bugs : UserControl
    {
        public testing_bugs()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            bugs.Children.Clear();
            bugs.Children.Add(new testing_och_and_objects());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            bugs.Children.Clear();
            bugs.Children.Add(new testing_bugs_example());
        }

        private void hyperlink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://helpdesk.zakupki.gov.ru/secure/Dashboard.jspa");
        }
    }
}
