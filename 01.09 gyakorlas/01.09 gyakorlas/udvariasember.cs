using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._09_gyakorlas
{
    internal class udvariasember:ember
    {
        public udvariasember(string vNev,string kNev):base(vNev,kNev) 
        {
                
        }
        public void koszon() 
        {
            Console.WriteLine("Szia uram!");
        }

        public void koszon(ember e)
        {
            Console.WriteLine("Szia {0} uram!", e.teljesNev);
        }
        public void koszonNevvel() 
        {
            Console.WriteLine("Szia uram! {0} vagyok!", teljesNev);
        }
        public void koszonNevvel(ember e)
        {
            Console.WriteLine("Szia {0} uram! {1} vagyok!", teljesNev,e.vezetekNev);
        }
    }
}
