using System;

namespace ArvSak
{
    class Program
    {
        static void Main(string[] args)
        {

           Databas db = new Databas();

            db.Add(new CD("Violator", "Depeche Mode"));
            db.Add(new CD("Some great reward", "Depeche Mode"));
            db.Add(new DVD("Lord of the Rings: The Fellowship of the Ring", "Peter Jackson"));
            db.Add(new DVD("Lord of the Rings: The Two Towers", "Peter Jackson"));
            db.Add(new DVD("Lord of the Rings: The Return of the King", "Peter Jackson"));
            db.SkrivUt();

        }
    }
}
