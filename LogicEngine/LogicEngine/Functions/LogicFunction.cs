using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Functions
{
    internal static class LogicFunction
    {
        internal static bool And(params bool[] values) => values.All(v => v);
        internal static bool Or(params bool[] values) => values.Any(v => v);
        internal static bool Not(bool value) => !value;
        internal static bool Xor(params bool[] values) => values.Count() % 2 == 1;
        internal static bool Nand(params bool[] values) => Not(And(values));
        internal static bool Nor(params bool[] values) => Not(Or(values));
        internal static bool XNor(params bool[] values) => Not(Xor(values));

        internal static class TwoInputs
        {
            internal static bool And(bool a, bool b) => a && b;
            internal static bool Or(bool a, bool b) => a || b;
            internal static bool Nand(bool a, bool b) => Not(And(a, b));
            internal static bool Nor(bool a, bool b) => Not(Or(a, b));
            internal static bool Xor(bool a, bool b) => a ^ b;
            internal static bool Xnor(bool a, bool b) => Not(Xor(a, b));
        }
    }
}
