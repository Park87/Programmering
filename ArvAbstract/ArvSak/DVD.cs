using System;
using System.Collections.Generic;
using System.Text;

namespace ArvSak
{
    class DVD:Sak
    {
        protected string regissör;

        public DVD(string t, string regissör)
        {
            titel = t;
            this.regissör = regissör;
        }

        public override void Act()
        {
            Console.WriteLine("DVD, Namn:" + titel);
            Console.WriteLine("Regissör:" + regissör);
        }
    }
}
