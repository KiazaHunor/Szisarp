using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzemanyag
{
    internal class adatok
    {
        public DateTime datum;
        public int benzin;
        public int gazolaj;

        public adatok(string sor) 
        {
            string[] vag = sor.Split(';');
            datum = Convert.ToDateTime(vag[0]);
            benzin = int.Parse(vag[1]);
            gazolaj = int.Parse(vag[2]);
        }
        public int kulonbseg()
        {
            return Math.Abs(benzin -gazolaj);
        }
    }

}
