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
    /// Логика взаимодействия для bugs_example_2.xaml
    /// </summary>
    public partial class bugs_example_2 : UserControl
    {
        public bugs_example_2()
        {
            InitializeComponent();
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            testing_bugs_example_2.Children.Clear();
            testing_bugs_example_2.Children.Add(new testing_widgets_data());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            testing_bugs_example_2.Children.Clear();
            testing_bugs_example_2.Children.Add(new testing_bugs_example());
        }
    }
}
