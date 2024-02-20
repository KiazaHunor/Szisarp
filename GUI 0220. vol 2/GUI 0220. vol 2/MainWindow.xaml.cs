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

namespace GUI_0220._vol_2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int osszeg =Convert.ToInt32(textbox1.Text) + Convert.ToInt32(textbox2.Text);
            textblock.Text = osszeg.ToString();

            textblock1.Text = textbox1.Text+"+"+ textbox2.Text+"="+ osszeg.ToString()+"\n"+ textblock1.Text;
        }
    }
}
