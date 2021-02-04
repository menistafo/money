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
    /// Логика взаимодействия для UserControl_ebzdb_example_3.xaml
    /// </summary>
    public partial class UserControl_ebzdb_example_3 : UserControl
    {
        public UserControl_ebzdb_example_3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            EBZDB_EXAMPLE_3.Children.Clear();
            EBZDB_EXAMPLE_3.Children.Add(new UserControl_ebzdb_example_4());
        }

        private void next_exmpl_Click(object sender, RoutedEventArgs e)
        {
            EBZDB_EXAMPLE_3.Children.Clear();
            EBZDB_EXAMPLE_3.Children.Add(new UserControl_ebzdb_example_7());
        }
    }
}
