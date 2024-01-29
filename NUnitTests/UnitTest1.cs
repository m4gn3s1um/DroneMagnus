using DroneMagnus;

namespace NUnitTests;

[TestFixture]
public class Tests
{
    
    [Test]
    public void AddTest()
    {
        NumberCalc nc = new NumberCalc();
        Assert.That(16, Is.EqualTo(nc.AddedNumbers(6, 10)));
    }
    
    [Test]
    public void RemoveTest()
    {
        NumberCalc nc = new NumberCalc();
        Assert.That(4, Is.EqualTo(nc.RemoveNumbers(10, 6)));
    }
}