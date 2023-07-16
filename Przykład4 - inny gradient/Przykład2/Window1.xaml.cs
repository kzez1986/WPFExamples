using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Przykład2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            slider3_ValueChanged(null, null);
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                RadialGradientBrush pędzel = ellipse1.Fill as RadialGradientBrush;
                double promień = 0.35;
                double kąt = 2 * Math.PI * slider4.Value;
                pędzel.GradientOrigin = new Point(0.5 + promień * Math.Cos(kąt),
                                                  0.5 + promień * Math.Sin(kąt));
                pędzel.GradientStops[0].Offset = slider1.Value;
                pędzel.GradientStops[1].Offset = slider2.Value;
                pędzel.GradientStops[2].Offset = slider3.Value;
            }
            catch
            {
                return;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
