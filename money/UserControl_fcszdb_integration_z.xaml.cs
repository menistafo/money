﻿using System;
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
    /// Логика взаимодействия для UserControl_fcszdb_integration_z.xaml
    /// </summary>
    public partial class UserControl_fcszdb_integration_z : UserControl
    {
        public UserControl_fcszdb_integration_z()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            integration_z.Children.Clear();
            integration_z.Children.Add(new UserControl_fcszdb_plan_graph_z());
        }

        private void further_Click(object sender, RoutedEventArgs e)
        {
            integration_z.Children.Clear();
            integration_z.Children.Add(new UserControl_fcszdb_rkpo_z());
        }
    }
}
