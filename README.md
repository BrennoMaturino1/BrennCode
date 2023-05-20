# BrennCode
An useful API i made, for console apps you can use ColorfulConsole that writes to the console with RGB colors and im working on a reliable math using strings instead of int, double, etc

# ColorfulConsole
This is a small class that allows you to write to console like `Console.WriteLine` and `Console.Write` does, but it has also 3 parameters where you specify RGB colors to write

# ColorfulConsole: How it works ?
I admit I got the code from [here](https://stackoverflow.com/a/43321133): `\x1b[38;2;" + r + ";" + g + ";" + b + "m" + text`

# BMath
BMath is the main resource of this API, providing a way of having a more precise math system by doing calculations in the "traditional" way instead of the normal, what i mean by "traditional" is like, adding each number instead of doing everything in one go like computers do, the only computer numbers used do not go past 18 (9 + 9) under normal circunstances.
