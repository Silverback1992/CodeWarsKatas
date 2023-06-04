using CodeWarsKatas.Katas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatasTest
{
    [TestFixture]
    public class CollatzKataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("3->10->5->16->8->4->2->1", CollatzKata.Collatz(3));
        }

        [Test]
        public void BasicTests2()
        {
            Assert.AreEqual("4->2->1", CollatzKata.Collatz(4));
        }
    }
}
