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

namespace Lab1Part5
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void LinkClicked(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            page2.Message = nameBox.Text + " !!!";// Зашиваем информацию в объект страницы
            var navigationService = this.NavigationService;
            if (navigationService != null) navigationService.Navigate(page2);
        }

    }
}
