using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    internal class XorGate : ILogicGate
    {
        internal List<ILogicGate> Inputs { get; }

        internal XorGate(IEnumerable<ILogicGate> inputs)
        {
            Inputs = inputs.ToList();
        }

        public virtual bool Evaluate(Dictionary<string, bool> inputs)
        {
            int trueCount = Inputs.Count(gate => gate.Evaluate(inputs));
            return trueCount % 2 == 1;
        }
    }
}
