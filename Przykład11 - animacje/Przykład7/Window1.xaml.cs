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
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Przykład7
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //button1.LayoutTransform = new RotateTransform(45);
            //button1.RenderTransform = new ScaleTransform(1.5, 0.5);
            /*
            DoubleAnimation animacja = new DoubleAnimation();
            animacja.From = 0.0;
            animacja.To = 360.0;
            animacja.Duration = new Duration(TimeSpan.FromSeconds(10));
            animacja.RepeatBehavior = RepeatBehavior.Forever;
            scenariusz = new Storyboard();
            scenariusz.Children.Add(animacja);
            obrót = (RotateTransform)button1.LayoutTransform;
            Storyboard.SetTargetName(animacja, "obrót");
            Storyboard.SetTargetProperty(animacja, new PropertyPath(RotateTransform.AngleProperty));
             */
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tekst");
        }
        private Storyboard scenariusz;
    }
}
