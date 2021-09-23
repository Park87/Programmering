using System;

namespace Testkod1
{
    class Solution
    {
        // konstruktor
        public Solution()
        {
        }
        public void Uppgift_1A()
        {
            Console.WriteLine("Hej Ada. Varmt Välkommen");
        }

        public void Uppgift_1B()
        {
            double bredd = 9.6;
            double höjd = 5.4;
            double area;
            area = bredd * höjd;
            Console.WriteLine("bredd " + bredd);
            Console.WriteLine("höjd " + höjd);
            Console.WriteLine("area " + area);

        }
        public void Uppgift_1C()
        {
            Console.WriteLine("bredd");
            string siffra = Console.ReadLine();
            double bredd = Convert.ToDouble(siffra);
            Console.WriteLine("höjd");
            string nummer = Console.ReadLine();
            double höjd = Convert.ToDouble(nummer);
            Console.WriteLine("bredd * höjd = " + bredd * höjd);


        }

        public void Uppgift_1D()
        {
            Console.WriteLine("nummer1");
            string nummer1 = Console.ReadLine();
            int tal1 = Convert.ToInt32(nummer1);
            Console.WriteLine("nummer2");
            string nummer2 = Console.ReadLine();
            int tal2 = Convert.ToInt32(nummer2);
            Console.WriteLine("tal1 + tal2 = " + (tal1 + tal2));

        }

        public void Uppgift_2A()
        {
            Console.WriteLine("Gissa mitt favorittal");

            Console.WriteLine("Skriv ditt tal");
            string Skrivditttal = Console.ReadLine();
            int tal = Convert.ToInt32(Skrivditttal);

            if (tal == 3)
            {
                Console.WriteLine("Du Gissade Rätt");
            }
            else
            {
                Console.WriteLine("Du Gissade Fel");
            }



        }

        public void Uppgift_2B()
        {
            Random randomGenerator = new Random();
            int antalkast = randomGenerator.Next(1, 7);
            int antalkast2 = randomGenerator.Next(1, 7);

            Console.WriteLine(antalkast + " " + antalkast2);

            if (antalkast == antalkast2)
            {
                Console.WriteLine("Vinst");
            }

            else
            {
                Console.WriteLine("Förlust");
            }

        }

        public void Uppgift_3A()
        {
            int räknare = 1;
            while (räknare < 6)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 1;
            }


        }

        public void Uppgift_3B()
        {
            int räknare = 5;
            while (räknare < 20)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 3;
            }
        }

        public void Uppgift_3C()
        {
            int räknare = 10;
            while (räknare > -1)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare - 1;
            }
        }

        public void Uppgift_4A()
        {
            for (int räknare = 1; räknare < 6; räknare = räknare + 1)
            {
                Console.WriteLine("" + räknare);
            }
        }

        public void Uppgift_4B()
        {
            for (int räknare = 5; räknare < 23; räknare = räknare + 3)
            {
                Console.WriteLine("" + räknare);
            }
        }

        public void Uppgift_4C()
        {
            for (int räknare = 10; räknare > -1; räknare = räknare - 1)
            {
                Console.WriteLine("" + räknare);
            }
        }

        public void Uppgift_5()
        {
            bool interätt = true;
            while (interätt)
            {
                Console.WriteLine("Gissa numret");
                string gissa = Console.ReadLine();
                if (gissa == "15")
                {
                    Console.WriteLine("Du Gissade rätt");
                    interätt = false;
                }

            }

        }

        public void Uppgift_6()
        {
            Random randomGenerator = new Random();
            int kast = randomGenerator.Next(1, 7);
            int kast2 = randomGenerator.Next(1, 7);

            if (kast == 6 && kast2 == 6)
            {
                Console.WriteLine("Storvinst");
            }
            if (kast == kast2)
            {
                Console.WriteLine("Liten vinst");
            }
            else
            {
                Console.WriteLine("Förlust");
            }


        }

        public void Uppgift_7A()
        {
            string[] lista = { "3", "5", "7", "9", "11", "13" };
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
            Console.WriteLine(lista[3]);
            Console.WriteLine(lista[4]);
            Console.WriteLine(lista[5]);
        }

        public void Uppgift_8A()
        {
            string[] lista = { "3", "5", "7", "9", "11", "13" };
            foreach (string talet in lista)
            {
                Console.WriteLine(talet);
            }
        }

        public void Uppgift_8B()
        {
            int[] lista = { 3, 5, 7, 9, 11, 13 };
            for (int räknare = 0; räknare < 6; räknare = räknare + 1)
            {
                lista[räknare] = lista[räknare] + 1;
                Console.WriteLine(lista[räknare]);
            }
        }

        public void Uppgift_9A()
        {
            welcome();

        }
        private void welcome()
        {
            Console.WriteLine("Välkommen Agent X. Ditt uppdrag är...");
        }

        public void Uppgift_9B()
        {
            Console.WriteLine(Addera(100, 8));
        }

        public int Addera(int a, int b)
        {
            return a + b;
        }
        public void Uppgift_9B2()
        {
            int a = Addera(5, 5);
            
        }

        public int Addera2(int a, int b, int c)
        {
            return a + b + c;
        }
        public void Uppgift_9B3()
        {
            int a = Addera2(5, 5, 5);
            Console.WriteLine(Addera2(5, 5, 5));
        }

        public void Uppgift_10()
        {
            String[] inköpslista = new String[100];
            int pos = 0;

            Console.WriteLine("Skriv in en vara");
            string text = Console.ReadLine();
            inköpslista[pos] = text;
            pos++;

            Console.WriteLine("Vill du skriva in fler varor?");
            string svar = Console.ReadLine();
            while (svar.Equals("j"))
            {
                Console.WriteLine("Skriv in en vara");
                string vara = Console.ReadLine();
                inköpslista[pos] = vara;
                pos++;


                Console.WriteLine("Vill du fortsätta j/n");
                svar = Console.ReadLine();
            }

            foreach (string liam in inköpslista)
            {
                if (liam!=null)
                {
                    Console.WriteLine(liam);
                }
                
            }


            

        }


    }
}
