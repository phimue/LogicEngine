using LogicEngine.Gates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.FlipFlops
{
    public class RsNAndFlipFlop : ILogicGate
    {
        private readonly InputGate setInput;
        private readonly InputGate resetInput;

        private bool? previousQ = null;

        public RsNAndFlipFlop(InputGate set, InputGate reset)
        {
            setInput = set;
            resetInput = reset;
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            //var S = setInput.Evaluate(inputs);
            //var R = resetInput.Evaluate(inputs);
            throw new NotImplementedException();
        }
    }
}
