using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PDMS
{
    class HexConverter
    {
        public string converter(string numberasstring)
        {
            BigInteger cinBI = new BigInteger();
            cinBI = BigInteger.Parse(numberasstring);
            string cinhex = cinBI.ToString("X");
            return cinhex;
        }
    }
}