using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BrennCode
{
    internal class Math
    {
        /// <summary>
        /// Add 2 numbers in the form of string, accepts "0-9." and returns 0 in case of illegal characters
        /// </summary>
        /// <param name="n1">First string to add</param>
        /// <param name="n2">Second string to add</param>
        /// <returns>string</returns>
        public static string Add(string n1, string n2)
        {
            if (HasIllegalChars(n1, n2))
            {
                return "0";
            }
            string[] n1Array = n1.Split();
            string[] n2Array = n2.Split();
            if (n1Array.Length == n2Array.Length && !n1.Contains("."))
            {
                for (int i = 0; i < n1Array.Length; i++)
                {
                    Int64 n1Parsed = Int64.Parse(n1Array[i]);
                    Int64 n2Parsed = Int64.Parse(n2Array[i]);
                    
                }
            }
            return "2";
        }

        public static bool HasIllegalChars(string n1, string n2)
        {
            Regex r = new Regex("0-9.");
            if ((r.IsMatch(n1) || n1.StartsWith("0")) || n2.StartsWith("0") || r.IsMatch(n2))
            {
                return false;
            }
            return true;
        }
    }
}
