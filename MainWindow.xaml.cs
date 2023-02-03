using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {    
        string playerSign = "x";
        string botSign = "o";

        public MainWindow()
        {
            InitializeComponent();

            Dostup(false);

            start.IsEnabled = true;
        }
   

        private void knopka_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text)) text.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        

        private void knopka1_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text1)) text1.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();

        }

        private void knopka2_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text2)) text2.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        private void knopka3_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text3)) text3.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        private void knopka4_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text4)) text4.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        private void knopka5_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text5)) text5.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        private void knopka6_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text6)) text6.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        private void knopka7_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text7)) text7.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        private void knopka8_Click(object sender, RoutedEventArgs e)
        {
            if (chekSign(text8)) text8.Text = playerSign; else MessageBox.Show("ты чо дебил? занято!");
            Robot();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            string[] arrRandSign = new string[] { "o","x" };

            Dostup(true);

            Random rnd = new Random();
            int value = rnd.Next(0, 2);
            playerSign = arrRandSign[value];
            MessageBox.Show(value.ToString());
            MessageBox.Show(playerSign);

            if (playerSign == "x")
            {
                botSign = "o";

            }
            else if (playerSign == "o")
            {
                botSign = "x";
            }


            text.Text = "";
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
            text6.Text = "";
            text7.Text = "";
            text8.Text = "";
        }

        private void Dostup(bool dost)
        {
            knopka.IsEnabled = dost;
            knopka1.IsEnabled = dost;
            knopka2.IsEnabled = dost;
            knopka3.IsEnabled = dost;
            knopka4.IsEnabled = dost;
            knopka5.IsEnabled = dost;
            knopka6.IsEnabled = dost;
            knopka7.IsEnabled = dost;
            knopka8.IsEnabled = dost;
        }
            bool chekSign(TextBlock tex)
            {
                if(tex.Text == "")
                {
                return true;
                }
                else
                {
                
                return false;
                }
            }

        private void Robot()
        {
     

                Random rnd = new Random();
                int value = rnd.Next(1, 9);
            
                if (chekSign(text) && value == 1)
                {
                    text.Text = botSign;
                   
                }
                else 

                if (chekSign(text1) && value == 2)
                {
                    text1.Text = botSign;
                   
                }
                else
                if (chekSign(text2) && value == 3)
                {
                    text2.Text = botSign;
                    
                }
                else

                if (chekSign(text3) && value == 4)
                {
                    text3.Text = botSign;
                 
                }
                else

                if (chekSign(text4) && value == 5)
                {
                    text4.Text = botSign;
                   
                }
                else

                if (chekSign(text5) && value == 6)
                {
                    text5.Text = botSign;
                  
                }
                else

                if (chekSign(text6) && value == 7)
                {
                    text6.Text = botSign;
                  
                }
                else

                if (chekSign(text7) && value == 8)
                {
                    text7.Text = botSign;
                    
                }
                else

                if (chekSign(text8) && value == 9)
                {
                    text8.Text = botSign;
                  
                }

            /*if (value == 1 )
            {
                text.Text = "x";
            }
            else 
            {
                text.Text = "o";
            }
            if (value == 2)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }
            if (value == 3)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }
            if (value == 4)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }
            if (value == 5)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }
            if (value == 6)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }
            if (value == 7)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }
            if (value == 8)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }
            if (value == 9)
            {
                text.Text = playerSign;
            }
            else
            {
                text.Text = "o";
            }*/

        }
    }

}
