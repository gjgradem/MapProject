using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Drawing;
using GoInspMap.ViewModel;

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
        }

        public int x = 0;
        public int y = 0;


        public void mouseClicked(object sender, MouseEventArgs e)
        {
            x = System.Windows.Forms.Cursor.Position.X;
            y = System.Windows.Forms.Cursor.Position.Y - 150;

        

            marker.Margin = new Thickness(x*2, y*2 - 68, 0, 0);

            Console.WriteLine(x *2);
            Console.WriteLine(y *2);


        }

        
    }
}
