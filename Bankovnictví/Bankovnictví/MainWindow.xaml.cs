using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace Bankovnictví
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

        int cislo;
        int cislo2;

        int result = 0;

        private void Vklad_Click(object sender, RoutedEventArgs e)
        {

            if (castka.Text == "")
            {

                castka.Text = "zadejte hodnotu";
            }

            else 
            {
                cislo = int.Parse(castka.Text);
                cislo2 = int.Parse(bucet.Text);
                result = cislo + cislo2;

                bucet.Text = result.ToString();
            };

            

          
           
        }

        private void Platba_Click(object sender, RoutedEventArgs e)
        {
            if (castka.Text == "")
            {

                castka.Text = "zadejte hodnotu";
            }

            else
            {
                cislo = int.Parse(castka.Text);
                cislo2 = int.Parse(sucet.Text);
                result = cislo + cislo2;

                sucet.Text = result.ToString();
            };


           
        }

        private void karta_Click(object sender, RoutedEventArgs e)
        {
            zobraz.Text = "";
            zobraz.Text = "Váš pin karty je 9425";
        }

        private void Blok_Click(object sender, RoutedEventArgs e)
        {
            zobraz.Text = "";
            zobraz.Text = "Váš účet je zablokován od jakékoli platby";
            castka.IsEnabled = false;
            anti.IsEnabled = true;
            Blok.IsEnabled = false;
            castka.Text = "";
            

        }

        private void anti_Click(object sender, RoutedEventArgs e)
        {
            zobraz.Text = "";
            zobraz.Text = "Váš účet je odblokován";
            castka.IsEnabled = true;
            anti.IsEnabled = false;
            Blok.IsEnabled = true;
        }

        private void kup_Click(object sender, RoutedEventArgs e)
        {
            cislo = int.Parse(castka.Text);
            cislo2 = int.Parse(bucet.Text);
            result = cislo2 - cislo;

            bucet.Text = result.ToString();
        }

      

        private void prevod_Click_1(object sender, RoutedEventArgs e)
        {
            if (castka.Text == "")
            {

                castka.Text = "zadejte hodnotu";
            }

            else
            {
                cislo = int.Parse(castka.Text);
                cislo2 = int.Parse(sucet.Text);
                result = cislo2 + cislo;

                sucet.Text = result.ToString();

                cislo = int.Parse(castka.Text);
                cislo2 = int.Parse(bucet.Text);
                result = cislo2 - cislo;

                bucet.Text = result.ToString();
            };

          
        }

        private void prevodz_Click(object sender, RoutedEventArgs e)
        {

            if (castka.Text == "")
            {

                castka.Text = "zadejte hodnotu";
            }

            else
            {
                cislo = int.Parse(castka.Text);

                cislo2 = int.Parse(sucet.Text);
                result = cislo2 - cislo;

                sucet.Text = result.ToString();

                cislo = int.Parse(castka.Text);
                cislo2 = int.Parse(bucet.Text);
                result = cislo2 + cislo;

                bucet.Text = result.ToString();
            };

          
        }

        private void trval_Click(object sender, RoutedEventArgs e)
        {
          cislo = int.Parse(castka.Text);
            zobraz.Text = "Trvalý příkaz je nastaven měsíčně. Částka je: " + castka.Text; 
            
        }

        private void pojisteni_Click(object sender, RoutedEventArgs e)
        {
            zobraz.Text = "";
            zobraz.Text = "Za bankovní pojištění platíte 56 Kč měsíčně na konci roku se vám odečte 672 Kč";
        }

        private void kontakt_Click(object sender, RoutedEventArgs e)
        {
          zobraz.Text= "";
            zobraz.Text = "Kontakt na naší pobočku je +420 652 502 958 nebo zameckabanka@bank.cz ";
        }

        private void castka_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
