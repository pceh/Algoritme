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
        decimal[] kosten = new decimal[] {2.50M, 2.75M, 3, 2, 1.50M, 2.20M, 7.50M, 8, 9 };


        public Product(string _naam, double _prijs)
        {
            this.naam = _naam;
            this.prijs = _prijs;
        }

        public Product()
        {
        }

        public decimal korting(decimal bedrag, int aanbreng)
        {
            //Aanbreng algoritme
            decimal huidigBedrag = bedrag;
            for (int i = 0; i < 10; i++) //for-loop voor aantal aangebrachten leden voor geselecteerde klant 'aanbreng' 
            {
                
                bedrag *= 0.99M;
                decimal bespaard = huidigBedrag - discount; //Hoeveel korting per iteratie
                decimal relatief = (bedrag - huidigBedrag) / huidigBedrag * 100;
                discount = bedrag;
            }
            return discount;
        }

        public decimal Totaal(int counter1, int counter2, int counter3, int counter4, int counter5, int counter6, int counter7, int counter8, int counter9)
        {
            //Afzet algoritme
            bedrag = counter1 * kosten[0] + counter2 * kosten[1] + counter3 * kosten[2] + counter4 * kosten[3] + counter5 * kosten[4] + counter6 * kosten[5] + counter7 * kosten[6] + counter8 * kosten[7] + counter9 * kosten[8];

            return bedrag;
        }

        public override string ToString()
        {
            return naam + prijs;
        }
    }
}
