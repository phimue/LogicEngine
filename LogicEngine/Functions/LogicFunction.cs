using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Functions
{
    public static class LogicFunction
    {
        public static bool And(params bool[] values) => values.All(v => v);
        public static bool Or(params bool[] values) => values.Any(v => v);
        public static bool Not(bool value) => !value;
        public static bool Xor(params bool[] values) => values.Count() % 2 == 1;
        public static bool Nand(params bool[] values) => Not(And(values));
        public static bool Nor(params bool[] values) => Not(Or(values));
        public static bool XNor(params bool[] values) => Not(Xor(values));

        public static class TwoInputs
        {
            public static bool And(bool a, bool b) => a && b;
            public static bool Or(bool a, bool b) => a || b;
            public static bool Nand(bool a, bool b) => Not(And(a, b));
            public static bool Nor(bool a, bool b) => Not(Or(a, b));
            public static bool Xor(bool a, bool b) => a ^ b;
            public static bool Xnor(bool a, bool b) => Not(Xor(a, b));

            public static class Abstract
            {
                public static bool Implication(bool a, bool b) => Or(Not(a), b);
                public static bool Replication(bool a, bool b) => Or(Not(b), a);
                public static bool Postsection(bool a, bool b) => And(a, Not(b));
                public static bool Presection(bool a, bool b) => And(b, Not(a));
            }
        }
    }
}
