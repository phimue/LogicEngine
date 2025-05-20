using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates
{
    internal class LogicGate : ILogicGate
    {
        internal string Name { get; set; }

        internal LogicGate(string name)
        {
            Name = name;
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            return inputs.TryGetValue(Name, out var value) && value;
        }
    }
}
