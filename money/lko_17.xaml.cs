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
    /// Логика взаимодействия для lko_17.xaml
    /// </summary>
    public partial class lko_17 : UserControl
    {
        public lko_17()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            lko17.Children.Clear();
            lko17.Children.Add(new lko_18());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            lko17.Children.Clear();
            lko17.Children.Add(new lko_16());
        }
    }
}
