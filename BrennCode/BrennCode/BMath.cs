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
            if (!n1.Contains(".") || !n2.Contains("."))
            {
                // basic sum operation
                return StringAdder(n1, n2);
            }
            else
            {
                var Numbers = EqualNumbers(n1, n2);
                string[] n1Split = n1.Split('.');
                string[] n2Split = n2.Split('.');

                return StringAdder(n1Split[0], n2Split[0]) + "." + StringAdder(n1Split[1], n2Split[1]);
            }
        }

        private static string StringAdder(string n1, string n2)
        {
            string[] n1Array = n1.Split();
            string[] n2Array = n2.Split();
            string[] resultArray = { };
            for (int i = 0; i < n1Array.Length; i++)
            {
                Int64 n1Parsed;
                bool n1Illegal = Int64.TryParse(n1Array[i], out n1Parsed);
                Int64 n2Parsed;
                bool n2Illegal = Int64.TryParse(n2Array[i], out n2Parsed);
                Int64 result = n1Parsed + n2Parsed;
                string[] resultStr = { result.ToString() };
                resultArray = resultArray.Concat(resultStr).ToArray();
                if (!n1Illegal || !n2Illegal)
                    return "0";
            }
            return String.Join("", resultArray);
        }
        private static (string n1Out, string n2Out, int bp) EqualNumbers(string n1, string n2)
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
