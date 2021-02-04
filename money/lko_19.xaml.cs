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
    /// Логика взаимодействия для lko_19.xaml
    /// </summary>
    public partial class lko_19 : UserControl
    {
        public lko_19()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            lko19.Children.Clear();
            lko19.Children.Add(new lko_20());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            lko19.Children.Clear();
            lko19.Children.Add(new lko_18());
        }
    }
}
