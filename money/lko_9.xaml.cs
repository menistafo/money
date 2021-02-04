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
    /// Логика взаимодействия для lko_9.xaml
    /// </summary>
    public partial class lko_9 : UserControl
    {
        public lko_9()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            lko9.Children.Clear();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            lko9.Children.Clear();
            lko9.Children.Add(new lko_8());
        }
    }
}
