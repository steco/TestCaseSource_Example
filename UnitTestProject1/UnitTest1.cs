using NUnit.Framework;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.That(1 + 1, Is.EqualTo(2));
        }
    }
}
