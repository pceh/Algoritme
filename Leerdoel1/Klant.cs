using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerdoel1
{
    class Klant
    {
        private string naam;
        private int affiliate_aantal;
        private decimal pasbedrag;
        public int user_status; //Moet toegangkelijk zijn voor de switch cases

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public int Affiliate_aantal
        {
            get { return affiliate_aantal; }
            set { affiliate_aantal = value; }
        }

        public decimal Pasbedrag
        {
            get { return pasbedrag; }
            set { pasbedrag = value; }
        }

        public Klant()
        {
            //Lege ctor voor vroegtijdige initialisatie
        }

        public Klant(string _naam, int _affiliate_aantal, decimal _pasbedrag)
        {
            this.affiliate_aantal = _affiliate_aantal;
            this.naam = _naam;
            this.pasbedrag = _pasbedrag;
        }


        public override string ToString()
        {
            switch (user_status)
            {
                case 1:
                    return affiliate_aantal.ToString();
                case 2:
                    return "Naam: " + Naam + "    Aantal: " + affiliate_aantal;
                case 3:
                    return "Naam: " + Naam + "    Saldo: " + pasbedrag;
                case 4:
                    return Naam;
                default:
                    return "Error: Geef een user_status aan";

            }
            //  if (user_status == 1)
            //  {
            //      return affiliate_aantal.ToString();
            //  }
            //  else
            //  {
            //      return "Naam: " + Naam + "    Aantal: " + affiliate_aantal;
            //  }
            //
            //  Ik kon geen elseif gebruiken?


        }

    }
}
