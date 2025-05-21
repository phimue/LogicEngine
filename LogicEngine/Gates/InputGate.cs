using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates
{
    public class InputGate : ILogicGate
    {
        public string Name { get; set; }

        public InputGate(string name)
        {
            Name = name;
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            return inputs.TryGetValue(Name, out var value) && value;
        }
    }
}
