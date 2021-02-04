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
    /// Логика взаимодействия для testing_bugs_example.xaml
    /// </summary>
    public partial class testing_bugs_example : UserControl
    {
        public testing_bugs_example()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            bugs_example.Children.Clear();
            bugs_example.Children.Add(new testing_bugs());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            bugs_example.Children.Clear();
            bugs_example.Children.Add(new bugs_example_2());
        }
    }
}
