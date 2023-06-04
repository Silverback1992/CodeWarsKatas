using CodeWarsKatas.Katas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatasTest
{
    [TestFixture]
    public class RomanNumeralsDecoderKataTests
    {
        [TestCase(1, "I")]
        [TestCase(21, "XXI")]
        public void Test(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanNumeralsDecoderKata.Solution(roman));
        }
    }
}
