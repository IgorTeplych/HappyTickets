using NUnit.Framework;

namespace HappyTickets.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void N2()
        {
            Assert.AreEqual(Program.Resolve(2), 670);

        }
        [Test]
        public void N3()
        {
            Assert.AreEqual(Program.Resolve(3), 55252);
        }
        [Test]
        public void N4()
        {
            Assert.AreEqual(Program.Resolve(4), 4816030);
        }
        [Test]
        public void N5()
        {
            Assert.AreEqual(Program.Resolve(5), 432457640);
        }
        [Test]
        public void N6()
        {
            Assert.AreEqual(Program.Resolve(6), 39581170420);
        }
        [Test]
        public void N7()
        {
            Assert.AreEqual(Program.Resolve(7), 3671331273480);
        }
        [Test]
        public void N8()
        {
            Assert.AreEqual(Program.Resolve(8), 343900019857310);
        }
        [Test]
        public void N9()
        {
            Assert.AreEqual(Program.Resolve(9), 32458256583753952);
        }
        [Test]
        public void N10()
        {
            Assert.AreEqual(Program.Resolve(10), 3081918923741896816);
        }
    }
}