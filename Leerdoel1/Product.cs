using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Leerdoel1
{
    class Product
    {
        private string naam;
        private double prijs;
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public decimal bedrag;
        private decimal discount;
        public decimal reset = 0;

        decimal[] kosten = new decimal[] {2.50M, 2.75M, 3, 2, 1.50M, 2.20M, 7.50M, 8, 9 };


        public Product(string _naam, double _prijs)
        {
            this.naam = _naam;
            this.prijs = _prijs;
        }

        public Product()
        {
        }

        public decimal korting(decimal bedrag, int aanbreng, ref decimal reset)
        {
            
            //Aanbreng algoritme
            decimal huidigBedrag = bedrag;
            for (int i = 0; i < aanbreng; i++) //for-loop voor aantal aangebrachten leden voor geselecteerde klant 'aanbreng' 
            {
                if (aanbreng < 10)
	        {
                bedrag *= 0.99M;
                decimal bespaard = huidigBedrag - discount; //Hoeveel korting per iteratie
                    try 
	            {	        
		            decimal relatief = (bedrag - huidigBedrag) / huidigBedrag * 100;
	            }
	                catch (System.DivideByZeroException) 
	            {
                    System.Windows.MessageBox.Show("Geen klant gekozen!");
	            }
                
                discount = bedrag;
	        } else
	        {
                bedrag *= 0.995M; // Bij een aanbreng > 10, halve procent minder korting
                decimal bespaard = huidigBedrag - discount; //Hoeveel korting per iteratie
                decimal relatief = (bedrag - huidigBedrag) / huidigBedrag * 100;
                discount = bedrag;
	        }
               
            }
            return discount;
            
            
        }

        public decimal Totaal(int counter1, int counter2, int counter3, int counter4, int counter5, int counter6, int counter7, int counter8, int counter9)
        {
            //Afzet algoritme
            bedrag = counter1 * kosten[0] + counter2 * kosten[1] + counter3 * kosten[2] + counter4 * kosten[3] + counter5 * kosten[4] + counter6 * kosten[5] + counter7 * kosten[6] + counter8 * kosten[7] + counter9 * kosten[8];
            int aantalGekocht = counter1 + counter2 + counter3 + counter4 + counter5 + counter6 + counter7 + counter8 + counter9;
            if (bedrag >= 25 || aantalGekocht > 10)
            {
                bedrag *= 0.80M; //Nu bij besteding van €25 EU of meer, 20% KORTING || Nieuwe actie: Bij aankoop van 10 of meer producten, ook 20% KORTING
            }
            return bedrag;
        }

        public override string ToString()
        {
            return naam + prijs;
        }
    }
}
