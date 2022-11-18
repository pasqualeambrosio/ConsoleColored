using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CConsole
{
    private static ConsoleColor defaultFontColor = ConsoleColor.Gray;
    private static ConsoleColor defaultBackgroundColor = ConsoleColor.Black;
    private static bool defaultColorsChanged = false;

    public enum Colors
    {
        Default,
        Muted,
        Secondary,
        Info,
        Warning,
        Error,
        BgDefault,
        BgMuted,
        BgInfo,
        BgWarning,
        BgError,
    }

    #region WriteLine / Write

    public static void WriteLine(string value, Colors colors)
    {
        WriteOnConsole(value, true, colors);
    }

    public static void Write(string value, Colors colors)
    {
        WriteOnConsole(value, false, colors);
    }

    public static void WriteLine(string value, ConsoleColor fontColor = ConsoleColor.Gray, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        WriteOnConsole(value, true, fontColor, backgroundColor);
    }

    public static void Write(string value, ConsoleColor fontColor = ConsoleColor.Gray, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        WriteOnConsole(value, false, fontColor, backgroundColor);
    }

    #endregion

    #region SetColors / ResetColors

    public static void SetColors(ConsoleColor fontColor = ConsoleColor.Gray, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        defaultColorsChanged = true;
        defaultFontColor = fontColor;
        defaultBackgroundColor = backgroundColor;
        Console.ForegroundColor = defaultFontColor;
        Console.BackgroundColor = defaultBackgroundColor;
    }

    public static void SetColors(Colors colors)
    {
        defaultColorsChanged = true;
        defaultFontColor = GetColors(colors)[0];
        defaultBackgroundColor = GetColors(colors)[1];
        Console.ForegroundColor = defaultFontColor;
        Console.BackgroundColor = defaultBackgroundColor;
    }

    public static void ResetColors()
    {
        defaultColorsChanged = false;
        defaultFontColor = ConsoleColor.Gray;
        defaultBackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = defaultFontColor;
        Console.BackgroundColor = defaultBackgroundColor;
    }

    #endregion

    #region Private Methods

    private static void WriteOnConsole(string value, bool withReturn, ConsoleColor fontColor = ConsoleColor.Gray, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        CheckDefaultColors(fontColor, backgroundColor);

        if (withReturn)
            Console.WriteLine(value);
        else
            Console.Write(value);

        Console.ForegroundColor = defaultFontColor;
        Console.BackgroundColor = defaultBackgroundColor;
    }

    private static void WriteOnConsole(string value, bool withReturn, Colors color)
    {
        CheckDefaultColors(color);

        if (withReturn)
            Console.WriteLine(value);
        else
            Console.Write(value);

        Console.ForegroundColor = defaultFontColor;
        Console.BackgroundColor = defaultBackgroundColor;
    }

    private static void CheckDefaultColors(ConsoleColor fontColor, ConsoleColor backgroundColor)
    {
        if (!defaultColorsChanged)
        {
            Console.ForegroundColor = fontColor;
            Console.BackgroundColor = backgroundColor;
        }
    }

    private static void CheckDefaultColors(Colors color)
    {
        if (!defaultColorsChanged)
        {
            Console.ForegroundColor = GetColors(color)[0];
            Console.BackgroundColor = GetColors(color)[1];
        }
    }

    private static ConsoleColor[] GetColors(Colors colors)
    {
        ConsoleColor[] res = new ConsoleColor[] { ConsoleColor.Gray, ConsoleColor.Black };

        switch (colors)
        {
            #region Without Background

            case Colors.Default:
                res[0] = ConsoleColor.Gray;
                break;

            case Colors.Muted:
                res[0] = ConsoleColor.DarkGray;
                break;

            case Colors.Info:
                res[0] = ConsoleColor.Cyan;
                break;

            case Colors.Warning:
                res[0] = ConsoleColor.Yellow;
                break;

            case Colors.Error:
                res[0] = ConsoleColor.DarkRed;
                break;

            #endregion

            #region With Background

            case Colors.BgDefault:
                res[0] = ConsoleColor.DarkGray;
                res[1] = ConsoleColor.Gray;
                break;

            case Colors.BgMuted:
                res[0] = ConsoleColor.White;
                res[1] = ConsoleColor.Gray;
                break;

            case Colors.BgInfo:
                res[0] = ConsoleColor.White;
                res[1] = ConsoleColor.Cyan;
                break;

            case Colors.BgWarning:
                res[0] = ConsoleColor.Black;
                res[1] = ConsoleColor.Yellow;
                break;

            case Colors.BgError:
                res[0] = ConsoleColor.White;
                res[1] = ConsoleColor.DarkRed;
                break;

                #endregion
        }

        return res;
    }

    #endregion


}

