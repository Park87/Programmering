using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class QuestionCard
    {
        private string fråga;
        private string svar;

        public QuestionCard(string f, string s)
        {
            fråga = f;
            svar = s;
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
