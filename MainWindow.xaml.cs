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

namespace WpfApp2911232
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawShapes();
        }
        private void DrawShapes()
        {
            Canvas canvas = new Canvas();
            Content = canvas;
            Ellipse ellipse = new Ellipse
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.LightBlue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            canvas.Children.Add(ellipse);
            Rectangle rectangle = new Rectangle
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.LightGreen,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(rectangle, 120);
            canvas.Children.Add(rectangle);
            Polygon triangle = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(50, 0),
                    new Point(0, 100),
                    new Point(100, 100)
                },
                Fill = Brushes.LightSalmon,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(triangle, 250);
            canvas.Children.Add(triangle);
        }
    }
}
        
    

