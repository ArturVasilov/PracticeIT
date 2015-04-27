using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfFinalWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private RubikCube _cube;

        public MainWindow()
        {
            InitializeComponent();
            RubikCube.GenerateAsync(rubikCube =>
            {
                _cube = rubikCube;
                DrawCube();
            });

        }

        private static void TryToWin(object obj)
        {
            RubikCube cube = (RubikCube) obj;
            cube.Move(RubikCube.CubeScroll.RandomScroll());
        }

        // ReSharper disable once FunctionComplexityOverflow
        private void DrawCube()
        {
            Field000.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 0, 0));
            Field001.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 0, 1));
            Field002.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 0, 2));
            Field010.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 1, 0));
            Field011.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 1, 1));
            Field012.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 1, 2));
            Field020.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 2, 0));
            Field021.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 2, 1));
            Field022.Background = new SolidColorBrush(_cube.GetCubePartColor(0, 2, 2));

            Field100.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 0, 0));
            Field101.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 0, 1));
            Field102.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 0, 2));
            Field110.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 1, 0));
            Field111.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 1, 1));
            Field112.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 1, 2));
            Field120.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 2, 0));
            Field121.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 2, 1));
            Field122.Background = new SolidColorBrush(_cube.GetCubePartColor(1, 2, 2));

            Field200.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 0, 0));
            Field201.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 0, 1));
            Field202.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 0, 2));
            Field210.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 1, 0));
            Field211.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 1, 1));
            Field212.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 1, 2));
            Field220.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 2, 0));
            Field221.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 2, 1));
            Field222.Background = new SolidColorBrush(_cube.GetCubePartColor(2, 2, 2));

            Field300.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 0, 0));
            Field301.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 0, 1));
            Field302.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 0, 2));
            Field310.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 1, 0));
            Field311.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 1, 1));
            Field312.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 1, 2));
            Field320.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 2, 0));
            Field321.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 2, 1));
            Field322.Background = new SolidColorBrush(_cube.GetCubePartColor(3, 2, 2));

            Field400.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 0, 0));
            Field401.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 0, 1));
            Field402.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 0, 2));
            Field410.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 1, 0));
            Field411.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 1, 1));
            Field412.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 1, 2));
            Field420.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 2, 0));
            Field421.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 2, 1));
            Field422.Background = new SolidColorBrush(_cube.GetCubePartColor(4, 2, 2));

            Field500.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 0, 0));
            Field501.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 0, 1));
            Field502.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 0, 2));
            Field510.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 1, 0));
            Field511.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 1, 1));
            Field512.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 1, 2));
            Field520.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 2, 0));
            Field521.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 2, 1));
            Field522.Background = new SolidColorBrush(_cube.GetCubePartColor(5, 2, 2));
        }

        private void Field000_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field000);
            Field000.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field001_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field001);
            Field001.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field002_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field002);
            Field002.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field010_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field010);
            Field010.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field011_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field011);
            Field011.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field012_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field012);
            Field012.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field020_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field020);
            Field020.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field021_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field021);
            Field021.Content = "X - " + point.X + "; Y - " + point.Y;
        }

        private void Field022_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field022);
            Field022.Content = "X - " + point.X + "; Y - " + point.Y;
        }
    }
}
