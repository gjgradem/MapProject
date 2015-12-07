using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GoInspMap
{
    public class MarkerTemplate : Image
    {
        System.Windows.Controls.Image pic = new System.Windows.Controls.Image();
        public MarkerTemplate()
        {
            this.Source = util.loadBitmap(GoInspMap.Properties.Resources.marker);
            this.MouseUp += MarkerTemplate_MouseUp;
        }

        void MarkerTemplate_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("CLICK");
        }
    }
}
