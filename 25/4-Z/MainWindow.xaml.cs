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

namespace _4_Z
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

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            B1.Visibility = Visibility.Hidden;
        }
        private void B1_MouseEnter(object sender, RoutedEventArgs e)
        {
            Button btn = new Button();
            btn.Width = 200;
            btn.Height = 100;
            btn.Content = "Созданная кнопка";     
            asd.Children.Add(btn);
        }
    }
}
