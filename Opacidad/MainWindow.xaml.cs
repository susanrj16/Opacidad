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

namespace Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 1;
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 1;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 0.5;
        }
    }
}
