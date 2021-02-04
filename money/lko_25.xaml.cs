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
    /// Логика взаимодействия для lko_25.xaml
    /// </summary>
    public partial class lko_25 : UserControl
    {
        public lko_25()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            lko25.Children.Clear();
            lko25.Children.Add(new lko_24());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            lko25.Children.Clear();
            lko25.Children.Add(new lko_26());
        }
    }
}
