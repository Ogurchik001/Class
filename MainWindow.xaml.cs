using Lukianov_Class.Views.Pages;
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

namespace Lukianov_Class
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

        private void J_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new JournalPage());
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Report1Page());
        }

        private void Ot_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Report2Page());
        }
    }
}
