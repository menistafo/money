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
    /// Логика взаимодействия для testing_mp_5.xaml
    /// </summary>
    public partial class testing_mp_5 : UserControl
    {
        public testing_mp_5()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            mp_5.Children.Clear();
            mp_5.Children.Add(new testing_mp_6());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            mp_5.Children.Clear();
            mp_5.Children.Add(new testing_mp_4());
        }
    }
}
