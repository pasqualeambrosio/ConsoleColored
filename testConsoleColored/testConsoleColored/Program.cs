using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsoleColored
{
    class Program
    {
        static void Main(string[] args)
        {

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


            Console.ReadKey();


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

            Console.ReadKey();
        }
    }
}
