using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    internal class OrGate : ILogicGate
    {
        internal List<ILogicGate> Inputs { get; }

        internal OrGate(IEnumerable<ILogicGate> inputs)
        {
            Inputs = inputs.ToList();
        }

        public virtual bool Evaluate(Dictionary<string, bool> inputs)
        {
            return Inputs.Any(gate => gate.Evaluate(inputs));
        }
    }
}
