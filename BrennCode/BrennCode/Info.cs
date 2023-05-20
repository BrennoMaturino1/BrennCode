using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennCode
{
    public class Info
    {
        /// <summary>
        /// Shows in the console a message about BrennCode
        /// </summary>
        public static void About()
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("This program is using BrennCode!");
            Console.WriteLine("BrennCode, or BC is a billboard that offers resources for console and WinForms apps");
            Console.WriteLine("Resources offered:");
            Console.WriteLine("MUUUCH More precise math (but slower for complex operations and support only strings)");
            Console.WriteLine("RGB Write & WriteLine for Console apps");
            Console.WriteLine("---DEVELOPED BY BRENNOMATURINO1---");
            Console.WriteLine("GIVE ME IDEAS ON GITHUB!");
            Console.WriteLine("github.com/BrennoMaturino1/BrennCode");

            Console.ForegroundColor = color;
        }
        public static void ChangeLog()
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("- I'm finnally back to the development!");
            Console.WriteLine("- BMath.Add is now working properly");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("---DEVELOPED BY BRENNOMATURINO1---");
            Console.WriteLine("github.com/BrennoMaturino1/BrennCode");

            Console.ForegroundColor = color;
        }
    }
}
