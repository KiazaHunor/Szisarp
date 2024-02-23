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

namespace Wpf_urlap_gyak_02._23
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

        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            string nev = textbox1.Text;
            string szul = textbox2.Text;
            string kor = textbox3.Text;

            if(nev=="" || szul=="" || kor == "") 
            {
                MessageBox.Show("töltsd ki mind");   
            }
            else 
            {
                listbox.Items.Add(nev + ", " + szul + ", " + kor);

                textbox1.Text = "";
                textbox2.Text = "";
                textbox3.Text = "";
            }


           

        }
    }
}
