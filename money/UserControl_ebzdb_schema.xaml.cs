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
    /// Логика взаимодействия для UserControl_ebzdb_schema.xaml
    /// </summary>
    public partial class UserControl_ebzdb_schema : UserControl
    {
        public UserControl_ebzdb_schema()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rgk_z.Children.Clear();
            rgk_z.Children.Add(new UserControl_ebzdb_schema_bank());           
        }
    }
}
