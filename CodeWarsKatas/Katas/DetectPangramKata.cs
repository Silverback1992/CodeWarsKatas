using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class DetectPangramKata
    {
        public static bool IsPangram(string str)
        {
            return Enumerable.Range('a', 'z' - 'a' + 1).All(x => str.ToLowerInvariant().ToCharArray().Any(y => y == x));
        }
    }
}
