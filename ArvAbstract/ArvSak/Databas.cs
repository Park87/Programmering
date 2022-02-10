using System;
using System.Collections.Generic;
using System.Text;

namespace ArvSak
{
    class Databas
    {
        List<Sak> Saker = new List<Sak>();

        public void Add(Sak EnSak)
        {
            Saker.Add(EnSak);

        }

        public void SkrivUt()
        {
            foreach (Sak i in Saker)
            {
                i.Act();
            }
        }


    }
}
