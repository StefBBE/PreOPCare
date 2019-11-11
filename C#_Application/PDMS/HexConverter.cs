using System.Numerics;

namespace PDMS
{
    class HexConverter
    {
        public string converter(string numberasstring)
        {
            BigInteger cinBI = BigInteger.Parse(numberasstring);
            string cinhex = cinBI.ToString("X");
            return cinhex;
        }
    }
}