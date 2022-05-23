using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrennCode
{
    public class ColorfulConsole
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleMode(IntPtr handle, out int mode);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetStdHandle(int handle);

        /// <summary>
        /// Write a line with your RGB color (0-255), Maybe i add a HEX method soon
        /// </summary>
        /// <param name="text">Your text</param>
        /// <param name="r">Red</param>
        /// <param name="g">Green</param>
        /// <param name="b">Blue</param>
        public static void WriteLine(string text, int r, int g, int b)
        {
            var handle = GetStdHandle(-11);
            int mode;
            GetConsoleMode(handle, out mode);
            SetConsoleMode(handle, mode | 0x4);

            Console.WriteLine("\x1b[38;2;" + r + ";" + g + ";" + b + "m" + text);
        }
    }
}
