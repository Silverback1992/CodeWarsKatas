using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public class CollatzKata
    {
        public static string Collatz(int n)
        {
            return n == 1 ? "1" : $"{n}->{Collatz((n % 2 == 0) ? (n / 2) : (3 * n + 1))}";

            //if (n == 1)
            //{
            //    return "1";
            //}
            //else
            //{
            //    int next = (n % 2 == 0) ? (n / 2) : (3 * n + 1);
            //    return $"{n}->{Collatz(next)}";
            //}
        }
    }
}
