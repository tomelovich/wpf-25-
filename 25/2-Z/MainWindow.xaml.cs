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

namespace _2_Z
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string input = string.Empty;
            if (string.IsNullOrEmpty(textBoxEnterName.Text) || string.IsNullOrWhiteSpace(textBoxEnterName.Text))
            {
                input = "Ivan";
            }
            else
            {
                input = textBoxEnterName.Text;
            }
            textBlockHello.Text = $"{ hello} {input }";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AboutApp aboutApp = new AboutApp();
            aboutApp.Show();
            
        }
    }
}
