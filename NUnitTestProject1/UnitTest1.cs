using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int i = 10;

            int j = i * 2;



            Assert.AreEqual(20, j);
        }
    }
}