using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

namespace _04._30_gyakorlas_D
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


        private void mezo(int sor, int oszlop, string tartalom)
        {
            Label cimke = new Label();
            cimke.Content = "awdaw";
            cimke.BorderBrush = Brushes.SlateBlue;
            cimke.BorderThickness= new Thickness(5);
            cimke.Background = Brushes.AliceBlue;
            cimke.Foreground = Brushes.White;
            cimke.Height = 20;
            cimke.Width = 20;
            cimke.Margin=new Thickness(cimke.Width*oszlop, cimke.Height*sor,0,0);
            cimke.HorizontalAlignment = HorizontalAlignment.Left;
            cimke.VerticalAlignment = VerticalAlignment.Top;
            tabla.Children.Add(cimke);
            
        }
      
    }
}
