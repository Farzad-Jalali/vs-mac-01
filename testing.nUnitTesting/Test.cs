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
            var p = new { id = 45, Name = "Farzad" };

            Assert.AreEqual(p.id, 45);


        }
    }
}
