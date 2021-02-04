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
    /// Логика взаимодействия для UserControl_Training.xaml
    /// </summary>
    public partial class UserControl_Training : UserControl
    {
        public UserControl_Training()
        {
            InitializeComponent();
        }

        private void testing_show(object sender, RoutedEventArgs e)
        {
            Testing testing = new Testing();
            testing.Show();
        }

        private void database_show(object sender, RoutedEventArgs e)
        {
            Database database = new Database();
            database.Show();
        }

        private void lko_show(object sender, RoutedEventArgs e)
        {
            lko lko = new lko();
            lko.Show();
        }

        private void info_show(object sender, RoutedEventArgs e)
        {
            info_ds info = new info_ds();
            info.Show();
        }
    }
}
