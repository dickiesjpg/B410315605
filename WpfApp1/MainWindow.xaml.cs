using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
     
    
    public partial class MainWindow : Window
    {
        public InkCanvas mydraw;
        public MainWindow()
        {
            InitializeComponent();
            mydraw = this.inkCanvas1;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingModeInverted = InkCanvasEditingMode.EraseByPoint;
            inkCanvas1.EraserShape = new EllipseStylusShape(5, 5);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DrawingAttributes o = new DrawingAttributes();
            o.Color = Colors.Red;
            o.Width = 10;
            mydraw.DefaultDrawingAttributes = o;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DrawingAttributes o = new DrawingAttributes();
            o.Color = Colors.Red;
            o.Width = 3;
            mydraw.DefaultDrawingAttributes = o;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DrawingAttributes o = new DrawingAttributes();
            o.Color = Colors.Green;
            o.Width = 10;
            mydraw.DefaultDrawingAttributes = o;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DrawingAttributes o = new DrawingAttributes();
            o.Color = Colors.Green;
            o.Width = 3;
            mydraw.DefaultDrawingAttributes = o;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
           
        }
    }
        


}

    


