using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Converters
{
    public static class BinaryCodeConverter
    {
        public static class GrayCode
        {
            public static string ToGray(string binary)
            {
                int n = Convert.ToInt32(binary, 2);
                int gray = n ^ (n >> 1);
                return Convert.ToString(gray, 2).PadLeft(binary.Length, '0');
            }

            public static string FromGray(string gray)
            {
                int g = Convert.ToInt32(gray, 2);
                int n = g;
                for (int shift = 1; (g >> shift) > 0; shift++)
                    n ^= (g >> shift);
                return Convert.ToString(n, 2).PadLeft(gray.Length, '0');
            }
        }

        public static class BCDCode
        {

        }
    }
}
