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

namespace Przykład5
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Button[] przyciski = new Button[100];
        public Window1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                przyciski[i] = new Button();
                Grid grid = new Grid();
                
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Random los = new Random();
            for(int i=0;i<100;i++)
            {
                //przyciski[i].Parent = this;
                przyciski[i].Width = 100;
                przyciski[i].Height = 200;
                przyciski[i].Margin.Right.Equals(12);
                przyciski[i].Margin.Top.Equals(20);
                przyciski[i].Margin.Bottom.Equals(20);
                przyciski[i].Name = "Przycisk" + i.ToString();
                przyciski[i].VerticalAlignment.Equals(Top);
                //Style buttonStyle = Window.Resources["CurvedButton"] as Style;
                //int sizeValue = ranNum.Next(50);
                przyciski[i].Name = "button" + i;
                przyciski[i].HorizontalAlignment = HorizontalAlignment.Left;
                przyciski[i].VerticalAlignment = VerticalAlignment.Top;
                int x1 = los.Next(300);
                int x2 = los.Next(300);
                int x3 = los.Next(300);
                int x4 = los.Next(300);
                przyciski[i].Margin = new Thickness(x1, 0, 0, 0);
                //przyciski[i].Style = buttonStyle;
                //foo.Click += new RoutedEventHandler(buttonClick);
                //LayoutRoot.Children.Add(przyciski[i]);
                //Grid.LayoutTransformProperty.ch
                LayoutRoot.Children.Add(przyciski[i]);
                
            }
        }
    }
}
