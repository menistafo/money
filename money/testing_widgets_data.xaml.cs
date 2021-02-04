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
    /// Логика взаимодействия для testing_widgets_data.xaml
    /// </summary>
    public partial class testing_widgets_data : UserControl
    {
        public testing_widgets_data()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            widgets_data.Children.Clear();
            widgets_data.Children.Add(new bugs_example_2());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            widgets_data.Children.Clear();
            widgets_data.Children.Add(new testing_widgets_card());
        }
    }
}
