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
    /// Логика взаимодействия для UserControl_ebzdb_schema_bank.xaml
    /// </summary>
    public partial class UserControl_ebzdb_schema_bank : UserControl
    {
        public UserControl_ebzdb_schema_bank()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            BANK_GUARANTEE_Z.Children.Clear();
            BANK_GUARANTEE_Z.Children.Add(new UserControl_ebzdb_schema());
        }

        private void examples_ebzdb_Click(object sender, RoutedEventArgs e)
        {
            BANK_GUARANTEE_Z.Children.Clear();
            BANK_GUARANTEE_Z.Children.Add(new UserControl_ebzdb_example_11());
        }
    }
}
