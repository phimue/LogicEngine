using LogicEngine.Functions;
using LogicEngine.Gates;
using LogicEngine.Gates.GateTypes;
using System.Diagnostics;

namespace LogicEngine.Test;

public class DeMorganTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FirstDeMorganTest()
    {
        ILogicGate input = new NAndGate(new[]
        {
            new InputGate("A"),
            new InputGate("B")
        });

        var convertedGate = DeMorganFunction.Convert(input);

        Assert.That(convertedGate, Is.TypeOf(typeof(OrGate)));
    }
}
