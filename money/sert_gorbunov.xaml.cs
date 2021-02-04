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
    /// Логика взаимодействия для sert_gorbunov.xaml
    /// </summary>
    public partial class sert_gorbunov : UserControl
    {
        public sert_gorbunov()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            gorbunov.Children.Clear();
            gorbunov.Children.Add(new sert_akimov());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            gorbunov.Children.Clear();
            gorbunov.Children.Add(new sert_savina());
        }
    }
}
