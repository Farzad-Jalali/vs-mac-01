using NUnit.Framework;
using System;
namespace testing.nUnitTesting
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            var p = new { id = 45, Name = "Farzad" , score = 23.5};

            Assert.AreEqual(p.id, 45);

        }
    }
}
