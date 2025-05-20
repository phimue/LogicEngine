using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    internal class NAndGate : ILogicGate
    {
        internal NotGate NotGate { get; }

        internal NAndGate(IEnumerable<ILogicGate> inputs)
        {
            var andGate = new AndGate(inputs);
            NotGate = new NotGate(andGate);
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            return NotGate.Evaluate(inputs);
        }

        
    }
}
