namespace _09._19_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lo = 0;
            while (lo <=100 || lo >999) 
            {
                Console.Write("Adjon meg egy 3 jegyű szamot:");
                lo = Convert.ToInt32(Console.ReadLine());

            }
            
            for (int i = 2; i < lo; i++)
            {
                if (lo % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //feladat 2
            int szam = 0;
            int szam1 = 0;
            while (szam <= 100 || szam > 999)
            while (szam1 <= 100 || szam1 > 999)
            {
                Console.Write("Adjon meg egy 3 jegyű szamot:");
                szam1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adjon meg egy 3 jegyű szamot:");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 2; i < szam; i++)
            {
                if (szam % i == 0 && szam1 % i ==0)
                {
                    Console.WriteLine(i);
                }
            }
            /*
            for (int i = 2; i < szam1; i++)
            {
                if (szam1 % i == 0 && szam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // Feladat3
            /*for (int i = 10000; i <= 99999; i++)
            {
                if (i % 620 == 0)
                {
                    Console.Write(i +" ");
                }
            }
            for (int i = -99999; i <= -10000; i++)
            {
                if (i % 620 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            */

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 100000; i > 10000; i--)
            {
                if (i % 620 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            for (int i = -10000; i > -100000; i--)
            {
                if (i % 620 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            // Feladat 4
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Adjon meg egy szamot:");
            int bea = Convert.ToInt32(Console.ReadLine());

            int tizedik = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (i % bea == 0)
                {
                    tizedik++;
                    Console.Write(i + "\t");
                    if (tizedik % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }


        }
    }
}