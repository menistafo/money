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
    /// Логика взаимодействия для lko_16.xaml
    /// </summary>
    public partial class lko_16 : UserControl
    {
        public lko_16()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            lko16.Children.Clear();
            lko16.Children.Add(new lko_15());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            lko16.Children.Clear();
            lko16.Children.Add(new lko_17());
        }
    }
}
