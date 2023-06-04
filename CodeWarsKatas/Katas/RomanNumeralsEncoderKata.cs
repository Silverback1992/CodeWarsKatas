using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class RomanNumeralsEncoderKata
    {
        public static string Solution(int n)
        {
            var romanNumeralsDict = new Dictionary<int, string>()
            {
                { 1000 , "M" },
                { 900 , "CM" },
                { 500 , "D" },
                { 400 , "CD" },
                { 100 , "C" },
                { 90 , "XC" },
                { 50 , "L" },
                { 40 , "XL" },
                { 10 , "X" },
                { 9 , "IX" },
                { 5 , "V" },
                { 4 , "IV" },
                { 1 , "I" }
            };

            string solution = "";

            foreach (var item in romanNumeralsDict)
            {
                solution = solution + string.Concat(Enumerable.Repeat(item.Value, (n / item.Key)));
                n = n % item.Key;
            }

            return solution;
        }
    }
}
