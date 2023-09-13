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
            int szam = 0;
            while ( szam < 999999)
            { 
               Console.Write("Adjon meg egy szamot: ");
               szam = Convert.ToInt32(Console.ReadLine());

                if (szam >= 100000)
                {
                    Console.WriteLine("A szam 6 jegyű.");
                }
                else if (szam >= 10000)
                {
                    Console.WriteLine("A szam 5 jegyű!");
                }
                else if (szam >= 1000)
                {
                    Console.WriteLine("A szam 4 jegyű");
                }
                else if (szam >= 100)
                {
                    Console.WriteLine("A szam 3 jegyű!");
                }
                else if (szam >= 10)
                {
                    Console.WriteLine("A szam 2 jegyű!");
                }
                else 
                {
                    Console.WriteLine("A szam 1 jegyű!");
                }
            }   
        




        }
    }
}
