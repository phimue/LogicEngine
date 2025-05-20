using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    internal class AndGate : ILogicGate
    {
        internal List<ILogicGate> Inputs { get; }

        internal AndGate(IEnumerable<ILogicGate> inputs)
        {
            Inputs = inputs.ToList();
        }

        public virtual bool Evaluate(Dictionary<string, bool> inputs)
        {
            return Inputs.All(gate => gate.Evaluate(inputs));
        }
    }
}
