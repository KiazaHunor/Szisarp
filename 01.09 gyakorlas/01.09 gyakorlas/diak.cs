using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._09_gyakorlas
{
    internal class diak:udvariasember
    {
        private int kor;
        public diak(string vNev, string kNev,int kor) : base(vNev, kNev) 
        {
            this.kor = kor;
        }
        public void iskola() 
        {
            if (kor < 2) { Console.WriteLine("OOOOOOadawaw!"); }
            else if (kor < 4) { Console.WriteLine("Bölcsibe!"); }
            else if (kor < 7) { Console.WriteLine("Óvodas vok!"); }
            else if (kor < 11) { Console.WriteLine("alsós vok!"); }
            else if (kor < 15) { Console.WriteLine("Felsős vok!"); }
            else if (kor < 20) { Console.WriteLine("Tekhnikumba jarok!"); }
            else if (kor < 25) { Console.WriteLine("Egyetem! Egyetem!"); }
            else { Console.WriteLine("Munkanelkuli!"); }
        }
        public void koszon(diak diakValtozo) 
        {
            Console.WriteLine("Csá {0}!", diakValtozo);
        }
    }
}
