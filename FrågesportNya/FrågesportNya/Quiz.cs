using System;
using System.Collections.Generic;
using System.Text;

namespace FrågesportNya
{
    class Quiz
    {
        private List<QuestionCard> frågor;
        private int KorrektaSvar = 0;


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
