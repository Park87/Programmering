using System;
using System.Collections.Generic;
using System.Text;

namespace ArvSak
{
    class CD:Sak
    {

        protected string Artist;

        public CD(string t, string Artist)
        {
            titel = t;
            this.Artist = Artist;
        }

        public override void Act()
        {
            Console.WriteLine("CD, Namn:" + titel);
            Console.WriteLine("Artist:" + Artist);
            
        }
    }
}
