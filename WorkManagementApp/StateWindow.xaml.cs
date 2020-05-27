﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkManagementApp
{
    /// <summary>
    /// StateWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class StateWindow : Window
    {
        public StateWindow()
        {
            InitializeComponent();
        }

        private void State_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}