using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_02._20_gyakorlas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool betoltott=false;
        public MainWindow()
        {
            InitializeComponent();

            this.betoltott = true;
        }

        double[] ertekek = new double[4] { 1, 1, 1, 1 };
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott) { 
            ertekek[0] = slider.Value;


            image1.Opacity = ertekek[0] * ertekek[3];

            image2.Opacity = (1-ertekek[0]) * ertekek[1];

            
            }
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott) { 
            ertekek[1] = slider1.Value;

            image2.Opacity = (1 - ertekek[0]) * ertekek[1];

            image3.Opacity = (1-ertekek[1]) * ertekek[2];
            }
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(betoltott)
            {
                ertekek[2] = slider2.Value;

                image3.Opacity = (1 - ertekek[1]) * ertekek[2];

                image4.Opacity= (1 - ertekek[2]) * ertekek[3];
            }
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott) 
            {
                ertekek[3] =slider3.Value;
                ertekek[3] = ((Slider)sender).Value;

                image4.Opacity = (1 - ertekek[2])* ertekek[3];

                image1.Opacity = (1-ertekek[3]) * ertekek[0];
            }
        }
    }
}
