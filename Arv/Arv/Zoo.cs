using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Zoo
    {
        List<cat> cats = new List<cat>();
        List<dog> dogs = new List<dog>();
        List<Cow> cows = new List<Cow>();

        public Zoo()
        {
            cats.Add(new cat(5));
            cats.Add(new cat(6));
            cats.Add(new cat(7));
            dogs.Add(new dog(5));
            dogs.Add(new dog(6));
            cows.Add(new Cow(5));
            cows.Add(new Cow(6));
            cows.Add(new Cow(7));


        }


        public void act()
        {
            foreach (cat i in cats)
            {
                i.act();
            }

            foreach  (dog i in dogs)
            {
                i.act();
            }

            foreach (Cow i in cows)
            {
                i.act();
            }
        }

    }
}
