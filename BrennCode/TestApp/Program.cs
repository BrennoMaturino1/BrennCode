using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrennCode;
namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info.About();
            ColorfulConsole.WriteLine("hello world", 50, 255, 255);
            ColorfulConsole.Write("hello ", 255, 0, 0);
            ColorfulConsole.Write("wor", 0, 255, 0);
            ColorfulConsole.WriteLine("ld", 0, 0, 255);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(BrennCode.Math.Add("1.0", "1.5"));
            Console.ReadKey();
        }
    }
}
