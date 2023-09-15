using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._13_ÓRA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy szamot");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(i * 10);
            }


            // Masodik feladat

            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i * k + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Adjon meg egy szamot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= szam2; i++)
            {
                for (int k = 0; k < szam2; k++)
                {
                    Console.Write(i * k + "\t");
                }
                Console.WriteLine();
            }

            // 3. feladat
            int szam3 = 0;
            for (int i = 0; i <= 999; i++)
            {
                szam3 += i;
                if (szam3 <= 999)
                {
                    Console.WriteLine(szam3);
                }
                else
                {
                    Console.WriteLine(i - 1);
                    break;
                }

            }



        }   


    }
}