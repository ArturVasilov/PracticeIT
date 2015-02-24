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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly System.Windows.Media.Brush color;
        bool _colorFlag = true;
    
        public MainWindow()
        {
            InitializeComponent();
    
            Btn1.Click += new RoutedEventHandler(Btn1_Click);
            color = this.Window.Background;
        }
    
        void Btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Window.Background = _colorFlag ? System.Windows.Media.Brushes.Purple : color;
            _colorFlag = !_colorFlag;
        }
    }
}
