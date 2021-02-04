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
    /// Логика взаимодействия для UserControl_payroll.xaml
    /// </summary>
    public partial class UserControl_payroll : UserControl
    {
        public UserControl_payroll()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((daytime_hours.Text.Equals("")) || (night_hours.Text.Equals("")) || position.Text.Equals(""))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание");
                btn_sum.Command = null;
            }
            else
            {
                string day = daytime_hours.Text;
                string night = night_hours.Text;
                int d;
                int n;
                d = Convert.ToInt32(day);
                n = Convert.ToInt32(night);
                int trainee;
                int employee;
                string trainee_sum;
                string employee_sum;
                int index = position.SelectedIndex;
                switch (index)
                {
                    case 0:
                        trainee = ((235 * d) + (282 * n));
                        trainee_sum = Convert.ToString(trainee);
                        //sum.Text = trainee_sum;
                        sum.Text = "ты молодец";
                        break;
                    case 1:
                        employee = ((290 * d) + (348 * n));
                        employee_sum = Convert.ToString(employee);
                        //sum.Text = employee_sum;
                        sum.Text = "ты молодец";
                        break;
                    case 2:
                        employee = ((300 * d) + (360 * n));
                        employee_sum = Convert.ToString(employee);
                        //sum.Text = employee_sum;
                        sum.Text = "ты молодец";
                        break;
                    case 3:
                        /*employee = ((235 * d) + (282 * n));
                        employee_sum = Convert.ToString(employee);*/
                        sum.Text = "sorry";
                        break;
                    case 4:
                        employee = ((310 * d) + (372 * n));
                        employee_sum = Convert.ToString(employee);
                        sum.Text = employee_sum;
                        break;
                    default:
                        break;
                }
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            night_hours.Clear();
            daytime_hours.Clear();
            position.Text = "";
            sum.Text = "";
        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
