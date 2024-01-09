using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._09_gyakorlas
{
    internal class ember
    {
        public string keresztNev;
        public string vezetekNev;
        public string teljesNev 
        {
            get { return vezetekNev + "" + keresztNev; }
        }

        public ember(string vNev,string kNev) 
        {
            vezetekNev = vNev;
            keresztNev = kNev;
        }
    }
}
