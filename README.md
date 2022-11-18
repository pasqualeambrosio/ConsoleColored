# ConsoleColored
C# Class for write color message on Console Application
<br><br>

## Basic Usage: Example 1
```c#
CConsole.WriteLine("Default", CConsole.Colors.Default);
CConsole.WriteLine("Muted", CConsole.Colors.Muted);
CConsole.WriteLine("Info", CConsole.Colors.Info);
CConsole.WriteLine("Warning", CConsole.Colors.Warning);
CConsole.WriteLine("Error", CConsole.Colors.Error);

CConsole.WriteLine("BgDefault", CConsole.Colors.BgDefault);
CConsole.WriteLine("BgMuted", CConsole.Colors.BgMuted);
CConsole.WriteLine("BgInfo", CConsole.Colors.BgInfo);
CConsole.WriteLine("BgWarning", CConsole.Colors.BgWarning);
CConsole.WriteLine("BgError", CConsole.Colors.BgError);

CConsole.Write("Hello ", CConsole.Colors.Error);
CConsole.WriteLine("World", CConsole.Colors.BgError);

```
![alt text](https://github.com/pasqualeambrosio/ConsoleColored/blob/main/preview1.png)

## Basic Usage: Example 2
```c#
CConsole.WriteLine("test1", ConsoleColor.DarkBlue);

CConsole.Write("Hello ", ConsoleColor.Blue);
CConsole.WriteLine("World", ConsoleColor.Green);
CConsole.WriteLine("test2");
CConsole.WriteLine(string.Format("test {0}", 3), ConsoleColor.Red, ConsoleColor.Green);

CConsole.SetColors(ConsoleColor.Red);

CConsole.WriteLine("test4");
CConsole.WriteLine("test5");

CConsole.ResetColors();

CConsole.WriteLine("test6", ConsoleColor.Blue);
CConsole.WriteLine("test7");

```
![alt text](https://github.com/pasqualeambrosio/ConsoleColored/blob/main/preview2.png)
