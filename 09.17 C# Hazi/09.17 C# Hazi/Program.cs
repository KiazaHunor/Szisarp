using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _09._17_C__Hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy 3 jegyű számot:");
            int szam = 0;Convert.ToInt32(Console.ReadLine());
            for (int i = 99; i < szam; i++)
            {
                for (int j = 0; j <= i; j++)

                if (szam < 999)
                {
                    Console.WriteLine(szam / j);
                    break;
                }
            }
        }
    }
}