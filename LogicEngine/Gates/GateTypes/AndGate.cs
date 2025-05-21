using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    public class AndGate : ILogicGate
    {
        public List<ILogicGate> Inputs { get; }

        public AndGate(IEnumerable<ILogicGate> inputs)
        {
            Inputs = inputs.ToList();
        }

        public virtual bool Evaluate(Dictionary<string, bool> inputs)
        {
            return Inputs.All(gate => gate.Evaluate(inputs));
        }
    }
}
