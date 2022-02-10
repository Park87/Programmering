using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Quiz
    {
        private List<QuestionCard> frågor;
        private int KorrektaSvar = 0;

        public Quiz()
        {
            frågor = new List<QuestionCard>();
            frågor.Add(new QuestionCard("Är det här en fråga?", "Ja"));
            frågor.Add(new QuestionCard("Vilken färg är solen?", "Gul"));

            frågor.Add(new QuestionCard("Är detta en flervalsfråga?\nA: Nej\nB: Kanske\nC: Vem vet?\nD: Ja", "D"));


        }

        public void Run()
        {
            foreach (QuestionCard blom in frågor)
            {
                if (blom.Act() == true)
                {
                    KorrektaSvar = KorrektaSvar + 1;
                    Console.WriteLine("Antal Korrekta Svar av 3 : " + KorrektaSvar);
                }

            }
                
                 
        }

    }
}
