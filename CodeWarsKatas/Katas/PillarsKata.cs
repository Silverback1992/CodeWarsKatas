using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class PillarsKata
    {
        public static int Pillars(int numPill, int dist, int width)
        {
            return numPill > 1 ? (numPill - 1) * dist * 100 + (numPill - 2) * width : 0;
        }
    }
}
