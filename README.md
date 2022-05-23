# BrennCode
A useful library i made, for console apps you can use ColorfulConsole that writes to the console with RGB colors and im working on a reliable math using strings instead of int, double, etc

# ColorfulConsole
This is a small class that allows you to write to console like `Console.WriteLine` and `Console.Write` does, but it has also 3 parameters where you specify RGB colors to write

# ColorfulConsole: How it works ?
You set flag ENABLE_VIRTUAL_TERMINAL_PROCESSING(0x4) using SetConsoleMode from kernel32.dll
And then write to the console with this confusing code that i got from [here](https://stackoverflow.com/a/43321133): "\x1b[38;2;" + r + ";" + g + ";" + b + "m" + text
