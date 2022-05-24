using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BrennCode
{
    public class Math
    {
        /// <summary>
        /// Add 2 numbers in the form of string, check the method "HasIllegalChars" for n1 and n2 rules
        /// </summary>
        /// <param name="n1">First string to add</param>
        /// <param name="n2">Second string to add</param>
        /// <returns>string</returns>
        public static string Add(string n1, string n2)
        {
            if (HasIllegalChars(n1) || HasIllegalChars(n2))
            {
                return "0";
            }
            string[] n1Array = n1.Split();
            string[] n2Array = n2.Split();
            if (n1Array.Length == n2Array.Length)
            {
                string[] resultArray = { };
                for (int i = 0; i < n1Array.Length; i++)
                {
                    Int64 n1Parsed = Int64.Parse(n1Array[i]);
                    Int64 n2Parsed = Int64.Parse(n2Array[i]);
                    Int64 result = n1Parsed + n2Parsed;
                    string[] resultStr = { result.ToString() };
                    resultArray = resultArray.Concat(resultStr).ToArray();
                }
                return String.Join("", resultArray);
            }
            return "bruh";
        }

        /// <summary>
        /// Checks for illegal characters in a number, you can use it, but in the operation methods the input is automatically checked
        /// <para>It should not have any letters or special characters, it only accepts "0-9" and "."</para>
        /// <para>Also don't start with things like ".5", always do 0.5 or it will be considered illegal</para>
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <returns></returns>
        public static bool HasIllegalChars(string n)
        {
            return !Regex.IsMatch(n, "[0-9.]", RegexOptions.IgnoreCase) && n.StartsWith(".");
        }
    }
}
