using LogicEngine.Gates;
using LogicEngine.Gates.GateTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Functions
{
    public static class DeMorganFunction
    {
        public static ILogicGate Convert(ILogicGate logicGate)
        {
            if (logicGate == null)
                throw new ArgumentNullException("Logic gate is not specified.");

            #region CallingFirstDeMorganLaw
            if (logicGate is NAndGate)
                return FirstDeMorganLaw(logicGate);

            if (logicGate is NotGate { Input: NAndGate nand })
                return FirstDeMorganLaw(nand);
            #endregion

            #region CallingSecondDeMorganLaw
            if (logicGate is NOrGate)
                return SecondDeMorganLaw(logicGate);

            if (logicGate is NotGate { Input: NOrGate nor })
                return SecondDeMorganLaw(nor);
            #endregion

            return logicGate;
        }

        private static OrGate FirstDeMorganLaw(ILogicGate gate)
        {
            AndGate andGate = gate is NAndGate nand
                ? nand.NotGate.Input as AndGate
                : (gate as NotGate)?.Input as AndGate;
            
            if (andGate == null)
                throw new ArgumentException("NAndGate does not wrap an AndGate");

            var negatedInputs = andGate.Inputs
                .Select(inputGate => new NotGate(inputGate))
                .Cast<ILogicGate>()
                .ToList();

            return new OrGate(negatedInputs);
        }

        private static AndGate SecondDeMorganLaw(ILogicGate gate)
        {
            OrGate orGate = gate is NOrGate nor
                ? nor.NotGate.Input as OrGate
                : (gate as NotGate)?.Input as OrGate;
            
            if (orGate == null)
                throw new ArgumentException("NOrGate does not wrap an OrGate");
            
            var negatedInputs = orGate.Inputs
                .Select(inputGate => new NotGate(inputGate))
                .Cast<ILogicGate>()
                .ToList();

            return new AndGate(negatedInputs);
        }
    }
}
