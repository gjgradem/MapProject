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
            ResizeMode = ResizeMode.NoResize;
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


    }
}
