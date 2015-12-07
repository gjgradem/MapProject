using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Navigation;
using GoInspMap.ViewModel;
using System.Windows.Input;
using System.Windows.Media;

namespace GoInspMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            marker.Visibility = Visibility.Hidden;
            //ResizeMode = ResizeMode.NoResize;
        }

        public float x = 0;
        public float y = 0;


        public void mouseClicked(object sender, MouseEventArgs e)
        {
            marker.Visibility = Visibility.Visible;
            Point locationFromWindow = this.TranslatePoint(new Point(0, 0), this);
            Point locationFromScreen = this.PointToScreen(locationFromWindow);

            x = System.Windows.Forms.Cursor.Position.X;
            y = System.Windows.Forms.Cursor.Position.Y - 150;


            marker.Margin = new Thickness((x - locationFromScreen.X) * 2, (y - locationFromScreen.Y) * 2 - 20, 0, 0);

            Console.WriteLine(locationFromScreen.X);
            Console.WriteLine(locationFromScreen.Y);


        }

        private void marker_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            marker.Visibility = Visibility.Hidden;
        }

        //private void KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Add)
        //    {
        //        Matrix m = svg3008.LayoutTransform.Value;

        //        if (m.M11 >= 4)
        //            return;

        //        m.M11 += 0.5;
        //        m.M22 += 0.5;

        //        svg3008.LayoutTransform = new MatrixTransform(m);
        //    }

        //    if (e.Key == Key.Subtract)
        //    {
        //        Matrix m = svg3008.LayoutTransform.Value;

        //        if (m.M11 <= 0.5)
        //            return;

        //        m.M11 -= 0.5;
        //        m.M22 -= 0.5;

        //        svg3008.LayoutTransform = new MatrixTransform(m);
        //    }

        }
    }

