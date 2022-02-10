using System;
using System.Collections.Generic;
using System.Text;

namespace FrågesportNya
{
    class QuestionCard
    {
        private string fråga;
        private string svar;
        private string svar1;
        private string svar2;

        public QuestionCard(string f, string s, string s1, string s2)
        {
            fråga = f;
            svar = s;
            svar1 = s1;
            svar2 = s2;
        }

        public string Fråga
        {
            get
            {
                return fråga;
            }
        }

        public bool Act()
        {
            Console.WriteLine(fråga);

            string gissning = Console.ReadLine();

            if (gissning == svar)
            {
                Console.WriteLine("Korrekt");
                return true;
            }

            else
            {
                Console.WriteLine("Fel");
                return false;
            }





        }

    }
}
