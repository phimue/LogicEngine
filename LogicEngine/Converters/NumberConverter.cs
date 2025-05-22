using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Converters
{
    public static class NumberConverter
    {
        public static string Convert(string input, int fromBase, int toBase)
        {
            int number = System.Convert.ToInt32(input, fromBase);

            return System.Convert.ToString(number, toBase).ToUpper();
        }

        public static char[] ConvertToArray(string input, int fromBase, int toBase)
        {
            return Convert(input, fromBase, toBase).ToCharArray();
        }
    }
}
