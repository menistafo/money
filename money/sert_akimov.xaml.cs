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
    /// Логика взаимодействия для sert_akimov.xaml
    /// </summary>
    public partial class sert_akimov : UserControl
    {
        public sert_akimov()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            akimov.Children.Clear();
            akimov.Children.Add(new pak_you__need_to_know());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            akimov.Children.Clear();
            akimov.Children.Add(new sert_gorbunov());
        }
    }
}
