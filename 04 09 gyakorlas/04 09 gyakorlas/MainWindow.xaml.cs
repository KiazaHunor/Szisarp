using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace _04_09_gyakorlas
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

        private int lnko(int a ,int b) 
        {
            return (int)(a + b);

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try 
            {
               szamlalo= Convert.ToInt32(szamlalo1.Text);
            }
            catch 
            { 
            }
            
            int nevezo = 0;
            try
            {
                szamlalo = Convert.ToInt32(nevezo1.Text);
            }
            catch
            {
            }
            if(  nevezo != 0 &&  szamlalo %nevezo==0 )
            {
                textBox.Text = (szamlalo / nevezo).ToString();
            }
            else if(nevezo != 0 && szamlalo % nevezo != 0)
            {
                textBox.Text = "Nem egész!";
            }
            else { textBox.Text = "Nullával való osztás!"; }
            
            textBlock1.Text =szamlalo.ToString();
            textBlock2.Text =nevezo.ToString();

            if( nevezo != 0 )
            {
                int oszto = lnko(nevezo, szamlalo);

                textBlock4.Text= (szamlalo/ oszto).ToString();
                textBlock3.Text = (szamlalo / oszto).ToString();

            }

        }
    }
}
