using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Info.ChangeLog();
            ColorfulConsole.WriteLine("hello world", 50, 255, 255);
            ColorfulConsole.Write("hello ", 255, 0, 0);
            ColorfulConsole.Write("wor", 0, 255, 0);
            ColorfulConsole.WriteLine("ld", 0, 0, 255);
            Console.ForegroundColor = ConsoleColor.Green;
            string add1 = "99.9";
            string add2 = "99.9";
            var sw = Stopwatch.StartNew();
            string addRes = BMath.Add(add1, add2);
            sw.Stop();
            Console.WriteLine($"O resultado de {add1} + {add2} é igual a " + addRes + $". O calulo foi feito em {sw.ElapsedMilliseconds} milisegundos");
            //199.8
            Console.ReadLine(); 
        }
    }
}
