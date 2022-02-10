using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfFordon
{
    class Vehicle
    {
        // registratoin number
        // owner
        private string regnumber;
        private string owner;

        public Vehicle(string r, string o)
        {
            regnumber = r;
            owner = o;
        }

        public string Regnumber
        {
            get
            {
                return regnumber;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }


        

        // konstruktor tar registeringsnummer som parameter

        // bara registreringsnummer

        // property för att läsa registreringsnummer

        // property för att läsa och sätta ägare
    }
}
