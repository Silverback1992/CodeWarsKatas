using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class RomanNumeralsDecoderKata
    {
        public static int Solution(string roman)
        {
            var romanNumeralsDict = new Dictionary<string, int>()
            {
                { "M" , 1000 },
                { "CM" , 900 },
                { "D" , 500 },
                { "CD" , 400 },
                { "C" , 100 },
                { "XC" , 90 },
                { "L" , 50 },
                { "XL" , 40 },
                { "X" , 10 },
                { "IX" , 9 },
                { "V" , 5 },
                { "IV" , 4 },
                { "I" , 1 }
            };

            int solution = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 != roman.Length)
                {
                    string pairOfNumerals = new string(new char[] { roman[i], roman[i + 1] });

                    if (romanNumeralsDict.ContainsKey(pairOfNumerals))
                    {
                        solution = solution + romanNumeralsDict[pairOfNumerals];
                        i++;
                        continue;
                    }
                }

                if (romanNumeralsDict.ContainsKey(roman[i].ToString()))            
                {
                    solution = solution + romanNumeralsDict[roman[i].ToString()];
                }
            }

            return solution;
        }
    }
}
