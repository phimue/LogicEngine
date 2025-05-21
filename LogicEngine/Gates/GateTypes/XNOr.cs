using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    internal class XNOr : ILogicGate
    {
        internal NotGate NotGate { get; }

        internal XNOr(IEnumerable<ILogicGate> inputs)
        {
            var xorGate = new XorGate(inputs);
            NotGate = new NotGate(xorGate);
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            return NotGate.Evaluate(inputs);
        }
    }
}
