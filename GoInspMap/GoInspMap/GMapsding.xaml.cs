using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace GoInspMap
{
    /// <summary>
    /// Interaction logic for GMapsding.xaml
    /// </summary>
    public partial class GMapsding : Window
    {
        GMapControl _control;
        public GMapsding()
        {
            InitializeComponent();
            _control = new GMapControl();
            _control.MapProvider = GoogleMapProvider.Instance;
            _control.SetPositionByKeywords("Nederland");
            _control.MinZoom = 3;
            _control.MaxZoom = 17;
            _control.Zoom = 7;
            _control.ShowCenter = true;
            _control.CanDragMap = true;

            addMarker(_control, "Den Bosch");
            addMarker(_control, "Eindhoven");
            addMarker(_control, "Amsterdam");

            _control.DragButton = MouseButton.Left;
            Map.Content = _control;
            
        }

        public void addMarker(GMapControl _control, String location)
        {
           _control.SetPositionByKeywords(location);
           GMap.NET.PointLatLng pt1 = _control.Position;
           GMapMarker marker1 = new GMapMarker(pt1);
           marker1.Shape = new MarkerTemplate();
           marker1.ZIndex = 1;
           _control.Markers.Add(marker1);
           
           Console.WriteLine("Should be added");

        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                addMarker(_control, input.Text);
            }
        }
    }
}
