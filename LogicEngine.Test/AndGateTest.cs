using LogicEngine.Gates;
using LogicEngine.Gates.GateTypes;

namespace LogicEngine.Test;

public class AndGateTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EvaluationTest()
    {
        ILogicGate circuit = new AndGate(new ILogicGate[] {
            new OrGate(new[]
            {
                new InputGate("A"),
                new InputGate("B")
            }),
            new OrGate(new ILogicGate[] {
                new InputGate("C"),
                new AndGate(new[]
                {
                    new InputGate("E"),
                    new InputGate("F")
                })
            })            
        });


        var inputs = new Dictionary<string, bool>
        {
            { "A", true },
            { "B", false },
            { "C", true },
            { "E", false },
            { "F", false },
        };

        var truthValue = circuit.Evaluate(inputs);
        
        Assert.IsTrue(truthValue);
    }
}
