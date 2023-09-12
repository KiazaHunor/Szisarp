using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Első
{
    class Program
    {
        private static bool i;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello Vilag!"[2]);
            int szam = 6;
            Console.WriteLine(szam);
            double masodik = 1.2;
            Console.WriteLine(masodik);
            char kar = 'k';
            Console.WriteLine(kar);
            char kar1 = 'k';
            Console.WriteLine(kar1);
            Console.WriteLine(kar1 + 2);
            char kari = 'a';
            Console.WriteLine(kari + 2);
            Convert.ToInt32(3);
            Console.WriteLine(10 % 3.0);
            Console.WriteLine(10 / 3.0);


            int a;
            a = 5;
            if (a > 2)
            {
                Console.WriteLine("Nagyobb");
            }
            else if (a < 2)
            {
                Console.WriteLine("Kisebb");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Egyenlő");
            }


            switch (a)
            {
                case 1:
                    Console.WriteLine("egy");
                    break;
                case 2:
                    Console.WriteLine("kettő");
                    break;
                case 3:
                    Console.WriteLine("három");
                    break;
                case 4:
                    Console.WriteLine("négy");
                    break;
                default:
                    Console.WriteLine("valami más");
                    break;

            }
            int b;
            b = 34;
            switch (b)

            {
                case 34:
                    Console.WriteLine("harmincnégy");
                    break;

            }
            double num = 1;
            while (num < 3)
            {
                Console.WriteLine(num);
                num += .1;
            }
            do
            {
                num -= .2;
                Console.WriteLine(num);


            }
            while (num > 2);

            char betu = 'a';
            while (betu <= 'z')
            {
                Console.Write(betu);
                betu = (char)(betu + 1);
            }
            Console.WriteLine();


            /*
            int l = 32;
            while (l <= 255)
            {
                Console.Write((char)l + " ");
                if (l % 8 == 7)
                {
                    Console.WriteLine();
                }
                l++;

            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)

            */

            Console.WriteLine();
           
            int szamol = 0; 
            for (int i = 100; i <= 1000; i++)
            {

                szamol += i;
            }
            Console.WriteLine(szamol);

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            /* HF 
            */

            for (int i = 10; i < 100; i += 5);
            {
                Console.WriteLine(i);
            }

        }   
    }
}
