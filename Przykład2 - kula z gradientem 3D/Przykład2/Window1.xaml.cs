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
            Color kolor = Color.FromRgb((byte)(255 * slider1.Value),
                                         (byte)(255 * slider2.Value),
                                         (byte)(255 * slider3.Value));
            double wsp = slider4.Value;
            Color kolorPoczątkowy = Color.FromRgb((byte)(kolor.R / wsp), (byte)(kolor.G / wsp), (byte)(kolor.B / wsp));
            RadialGradientBrush pędzel = new RadialGradientBrush(kolor, kolorPoczątkowy);
            pędzel.GradientOrigin = new Point(0.75, 0.25);
            ellipse1.Fill = pędzel;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
