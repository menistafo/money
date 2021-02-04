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
    /// Логика взаимодействия для UserControl_graph.xaml
    /// </summary>
    public partial class UserControl_graph : UserControl
    {
        public UserControl_graph()
        {
            InitializeComponent();
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            login_graph.Clear();
            pass_graph.Clear();            
        }

        private void btn_input_Click(object sender, RoutedEventArgs e)
        {
            if ((login_graph.Text.Equals("")) || (pass_graph.Password.Equals("")) || (login_graph.Text!=("uhfabrv'y")) || (pass_graph.Password!=("kexibquhfabr")))
            {
                MessageBox.Show("Не корректные данные", "Внимание");
                btn_input.Command = null;
            }
            else
            {
                
            }
        }
    }
}
