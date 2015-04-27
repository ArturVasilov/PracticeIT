using System.Windows;
using System.Windows.Controls;
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

        private static void TryWin(object obj)
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
            MoveCube(0, 0, 0, point);
        }

        private void Field002_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field002);
            MoveCube(0, 0, 2, point);
        }

        private void Field020_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field020);
            MoveCube(0, 2, 0, point);
        }

        private void Field022_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field022);
            MoveCube(0, 2, 2, point);
        }

        private void Field100_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field100);
            MoveCube(1, 0, 0, point);
        }

        private void Field102_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field102);
            MoveCube(1, 0, 2, point);
        }

        private void Field120_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field120);
            MoveCube(1, 2, 0, point);
        }

        private void Field122_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field122);
            MoveCube(1, 2, 2, point);
        }

        private void Field200_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field200);
            MoveCube(2, 0, 0, point);
        }

        private void Field202_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field202);
            MoveCube(2, 0, 2, point);
        }

        private void Field220_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field220);
            MoveCube(2, 2, 0, point);
        }

        private void Field222_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field222);
            MoveCube(2, 2, 2, point);
        }

        private void Field300_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field300);
            MoveCube(3, 0, 0, point);
        }

        private void Field302_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field302);
            MoveCube(3, 0, 2, point);
        }

        private void Field320_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field320);
            MoveCube(3, 2, 0, point);
        }

        private void Field322_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field422);
            MoveCube(4, 2, 2, point);
        }

        private void Field400_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field400);
            MoveCube(4, 0, 0, point);
        }

        private void Field402_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field402);
            MoveCube(4, 0, 2, point);
        }

        private void Field420_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field420);
            MoveCube(4, 2, 0, point);
        }

        private void Field422_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field422);
            MoveCube(4, 2, 2, point);
        }

        private void Field500_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field500);
            MoveCube(5, 0, 0, point);
        }

        private void Field502_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field502);
            MoveCube(5, 0, 2, point);
        }

        private void Field520_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field520);
            MoveCube(5, 2, 0, point);
        }

        private void Field522_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(Field522);
            MoveCube(5, 2, 2, point);
        }

        private void MoveCube(int face, int row, int column, Point point)
        {
            RubikCube.ScrollDirection direction;
            if (point.Y >= 99) direction = RubikCube.ScrollDirection.Top;
            else if (point.Y <= 33) direction = RubikCube.ScrollDirection.Bottom;
            else if (point.X <= 66) direction = RubikCube.ScrollDirection.Left;
            else direction = RubikCube.ScrollDirection.Right;

            RubikCube.CubeScroll scroll = new RubikCube.CubeScroll(face, row, column, direction);
            _cube.Move(scroll);

            if (_cube.IsWon())
            {
                //TODO : game finished
            }

            DrawCube();
        }
    }
}
