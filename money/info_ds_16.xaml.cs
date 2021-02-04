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
    /// Логика взаимодействия для info_ds_16.xaml
    /// </summary>
    public partial class info_ds_16 : UserControl
    {
        public info_ds_16()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            info_ds16.Children.Clear();
            info_ds16.Children.Add(new info_ds_15());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            info_ds16.Children.Clear();
            info_ds16.Children.Add(new info_ds_17());
        }
    }
}
