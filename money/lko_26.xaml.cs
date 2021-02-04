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
    /// Логика взаимодействия для lko_26.xaml
    /// </summary>
    public partial class lko_26 : UserControl
    {
        public lko_26()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            lko26.Children.Clear();
            lko26.Children.Add(new lko_25());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            lko26.Children.Clear();
            lko26.Children.Add(new lko_27());
        }
    }
}
