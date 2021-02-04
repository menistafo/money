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
    /// Логика взаимодействия для testing_pak_2.xaml
    /// </summary>
    public partial class testing_pak_2 : UserControl
    {
        public testing_pak_2()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            pak_2.Children.Clear();
            pak_2.Children.Add(new testing_pak_3());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            pak_2.Children.Clear();
            pak_2.Children.Add(new testing_pak_1());
        }
    }
}
