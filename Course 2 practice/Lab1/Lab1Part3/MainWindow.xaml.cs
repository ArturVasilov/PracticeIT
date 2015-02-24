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

namespace Lab1Part3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int _createCount;
        public MainWindow()
        {
            InitializeComponent();
    
            // Определение заголовка окна и назначение главного окна
            if (_createCount == 3)
            {
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Application.Current.MainWindow = this;
                this.Title = "Главное окно № " + (_createCount++).ToString();
            }
            else
                this.Title = "Окно № " + (_createCount++).ToString();
        }
    
        private void NewWindowClicked(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
    
        private void ListOpenWindows(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Window openWindow in Application.Current.Windows)
                sb.AppendLine(openWindow.Title);
    
            MessageBox.Show(sb.ToString(), "Открытые окна приложения");
        }
    
        private void AllCloseWindows(object sender, RoutedEventArgs e)
        {
            //Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();// Закрывает при любом режиме
        }

    }
}
