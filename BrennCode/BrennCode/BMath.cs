using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BrennCode
{
    public class BMath
    {
        /// <summary>
        /// Add 2 string numbers
        /// <br/> If you put something like a point or a letter (Anything it will give you the wrong result)
        /// </summary>
        /// <param name="n1">First number to add</param>
        /// <param name="n2">Second number to add</param>
        /// <returns>Returns string</returns>
        public static string Add(string n1, string n2)
        {
            /*if (!n1.Any(x => char.IsLetter(x) || !char.IsPunctuation(x)) || !n2.Any(x => char.IsLetter(x) || !char.IsPunctuation(x)))
                return "0";*/



            if (n1.Any(x => char.IsPunctuation(x)) || n2.Any(x => char.IsPunctuation(x)))
            {
                string[] n1Split = n1.Split('.');
                string[] n2Split = n2.Split('.');
                int carry = 0;
                string add1 = rawAdd(n1Split[1], n2Split[1], ref carry);
                string add0 = rawAdd(n1Split[0], n2Split[0], ref carry);

                return carry + add0 + "." + add1;
            }
            return "0";

        }

        private static string rawAdd(string n1, string n2, ref int carry)
        {
            var eq = EqualNumbers(n1, n2);
            n1 = eq.n1Out; n2 = eq.n2Out;
            List<String> output = new List<String>();
            for (int i = n1.Length; i-- > 0;)
            {
                int n1Int = int.Parse(n1[i].ToString());
                int n2Int = int.Parse(n2[i].ToString());

                int result = n1Int + n2Int + carry;
                carry = result / 10;
                output.Add((result % 10).ToString());
            }
            return String.Join("", output.ToArray());
        }

        private static string rawSubtract(string n1, string n2, ref int carry)
        {
            var eq = EqualNumbers(n1, n2);
            n1 = eq.n1Out; n2 = eq.n2Out;
            
        }

        private static (string n1Out, string n2Out, int npadded) EqualNumbers(string n1, string n2)
        {
            if (n1.Length > n2.Length)
            {
                string b2 = n2.PadLeft(n1.Length, '0');
                return (b2, n1, 1);
            }
            else if (n1.Length < n2.Length)
            {
                string a2 = n1.PadLeft(n2.Length, '0');
                return (n1, a2, 2);
            }
            else
            {
                return (n1, n2, 0);
            }
        }
    }
}
