using System.Windows;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*public App()
        {
            // Подписались на событие, что запущен объект Application 
            this.Startup += new StartupEventHandler(App_Startup);
            // На всякий случай подписались на событие необработанных исключений
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        void App_DispatcherUnhandledException(object sender,
            System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;// Продолжить выполнение
        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            // Создаем объект стартового окна
            MainWindow win = new MainWindow {Title = "MainWindow"};
            // Настраиваем объект окна
            // Показываем окно
            win.Show();
        }*/

    }
}
