using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            cat minKatt = new cat(5);
            minKatt.act();

            dog minHund = new dog(5);
            minHund.act();

            Console.WriteLine();

            Zoo mittZoo = new Zoo();
            mittZoo.act();


        }
    }
}
