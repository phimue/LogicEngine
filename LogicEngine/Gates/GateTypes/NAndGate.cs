using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    public class NAndGate : ILogicGate
    {
        public NotGate NotGate { get; }

        public NAndGate(IEnumerable<ILogicGate> inputs)
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
