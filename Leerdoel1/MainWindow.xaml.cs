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

namespace Leerdoel1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int[] counter = new int[9];
        //Vroegtijdig initialiseren voor button_Clicks
        Product prod = new Product();
        Klant klantClass = new Klant();

        List<Klant> nieuw = new List<Klant>()
            {
                new Klant{ Naam = "Foobar", Affiliate_aantal = 2, Pasbedrag = 20.10M},
                new Klant{ Naam = "John Doe", Affiliate_aantal = 8, Pasbedrag = 5.50M},
                new Klant{ Naam = "Mary Jane", Affiliate_aantal = 5, Pasbedrag = 40.80M},
                new Klant{ Naam = "Jeff", Affiliate_aantal = 10, Pasbedrag = 40.80M}
            };

        public MainWindow()
        {
            InitializeComponent();
            
            foreach (var item in nieuw)
            {
                item.user_status = 2; //Switch in override ToString 'Klant'
                klantlijst.Items.Add(item.ToString());
            }

            foreach (var item in nieuw)
            {
                item.user_status = 3; //Switch in override ToString 'Klant'
                barpas_lijst.Items.Add(item.ToString());
                item.user_status = 1; //Nu is default status van de gebruiker alleen het affiliate_aantal om later mee te rekenen
            }

            
        }
       
        private void Korting_Click(object sender, RoutedEventArgs e)
        {

            //Haal aantal aangebrachten klanten op door user_status = 1 

            //Probleem met afronden
            //Door de ToString 
            //Problemen met mijn override ToString(), user_status wordt door 'klantlijst_SelectionChanged' steeds op 4 gezet
            //int positie = klantlijst.SelectedIndex;
            //string aantal = nieuw[positie].ToString(); //Haal aantal aangebrachten klanten op door user_status = 1 
            try
            {
                foreach (var item in nieuw)
                {
                    item.user_status = 1;


                    int positie = klantlijst.SelectedIndex;
                    newprijs.Content = nieuw[positie].ToString();
                    int selectklant = Convert.ToInt32(nieuw[positie].ToString());
                    //Heel "netjes" afronden
                    string afronden = prod.korting(prod.bedrag, selectklant,ref prod.reset).ToString(); //Methode in Product.cs (Line:31)
                    decimal afronden2 = Convert.ToDecimal(afronden);
                    decimal kortingBedrag = Decimal.Round(afronden2, 2);
                    newprijs.Content = kortingBedrag.ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Je moet een klant kiezen!"); //Try-catch zat in de foreach loop, kreeg 4x (4 list items) aan messageboxes

            }
            
            //Probleem met afronden
            //Door de ToString 
            //Problemen met mijn override ToString(), user_status wordt door 'klantlijst_SelectionChanged' steeds op 4 gezet
            

        }

        private void klantlijst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Gebruikersnaam weergeven bij korting << WERKT NIET

            //item.user_status = 4;

            //int positie = klantlijst.SelectedIndex;
            //newnaam.Content = nieuw[positie].ToString();

            //Zonder foreach krijg ik steeds het aantal aangebrachten aan (case:1 Klant.cs)
            //foreach (var item in nieuw)
            //{
            //item.user_status = 1;
            //int positie = klantlijst.SelectedIndex;
            //newnaam.Content = nieuw[positie].ToString();

            //item.user_status = 1;
            //}


        }

        //Bieren
        private void BierA_Click(object sender, RoutedEventArgs e)
        {
            
            counter[0]++;
            amt1.Content = counter[0].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            
            totaal.Content = prod.bedrag.ToString();
        }

        private void BierB_Click(object sender, RoutedEventArgs e)
        {
     
            counter[1]++;
            amt2.Content = counter[1].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();

        }

        private void BierC_Click(object sender, RoutedEventArgs e)
        {
            counter[2]++;
            amt3.Content = counter[2].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();
        }

 

        //Frisdrank
        private void FrisA_Click(object sender, RoutedEventArgs e)
        {
            counter[3]++;
            amt4.Content = counter[3].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();
        }

        private void FrisB_Click(object sender, RoutedEventArgs e)
        {
            counter[4]++;
            amt5.Content = counter[4].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();
        }

        private void FrisC_Click(object sender, RoutedEventArgs e)
        {
            counter[5]++;
            amt6.Content = counter[5].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();
        }

        //Eten
        private void EtenA_Click(object sender, RoutedEventArgs e)
        {
            counter[6]++;
            amt7.Content = counter[6].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();
        }

        private void EtenB_Click(object sender, RoutedEventArgs e)
        {
            counter[7]++;
            amt8.Content = counter[7].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();
        }

        private void EtenC_Click(object sender, RoutedEventArgs e)
        {
            counter[8]++;
            amt9.Content = counter[8].ToString();
            prod.Totaal(counter[0], counter[1], counter[2], counter[3], counter[4], counter[5], counter[6], counter[7], counter[8]);
            totaal.Content = prod.bedrag.ToString();
        }

    }
}
