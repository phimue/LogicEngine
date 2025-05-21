using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates
{
    public interface ILogicGate
    {
        public bool Evaluate(Dictionary<string, bool> inputs);
    }
}
