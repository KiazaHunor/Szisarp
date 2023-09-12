using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Adj meg egy szoveget pls: ");
            string szoveg = Console.ReadLine();

            Console.WriteLine("A bekert szöveg " + szoveg);


            //ures sor vegjelig
            szoveg = " ";
            while (szoveg != "")
            {
                Console.Write("Kérek egy szót: ");
                szoveg = Console.ReadLine();
            }
            //Hf szavak bekerese,ures vegjelig.Összegyujtve egy valtozoba valtozoba, valahogy elvalasztva 

            Console.Write("Kerek egy egesz szamot:");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a szam negyzete " + (szam * szam+1));
            */

            Console.Write("kerek egy szamot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szam; i++)
            { 
                Console.WriteLine("Kerem a(z)"+(i+1)+"szót: ");
                Console.ReadLine();

            }
            Console.Write("kerek egy szamot: ");
            int karakter = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szam; i++)
            {
                
            }
        }
    }
}
