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
    /// Логика взаимодействия для UserControl_fcszdb_example_timestamp.xaml
    /// </summary>
    public partial class UserControl_fcszdb_example_timestamp : UserControl
    {
        public UserControl_fcszdb_example_timestamp()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FCSZDB_EXAMPLE_timestamp.Children.Clear();
            FCSZDB_EXAMPLE_timestamp.Children.Add(new UserControl_fcszdb_example_4_18());
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            FCSZDB_EXAMPLE_timestamp.Children.Clear();
            FCSZDB_EXAMPLE_timestamp.Children.Add(new UserControl_fcszdb_example_priz());
        }
    }
}
