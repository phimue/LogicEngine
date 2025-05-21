using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    public class OrGate : ILogicGate
    {
        public List<ILogicGate> Inputs { get; }

        public OrGate(IEnumerable<ILogicGate> inputs)
        {
            Inputs = inputs.ToList();
        }

        public virtual bool Evaluate(Dictionary<string, bool> inputs)
        {
            return Inputs.Any(gate => gate.Evaluate(inputs));
        }
    }
}
