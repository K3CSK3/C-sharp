using System.Runtime.CompilerServices;
using System.Transactions;

namespace System;

public static class ExtendedSystem
{
    public static void WriteToConsole(this object number)
    {
        Console.WriteLine(number);
    }

    public static int Summary(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Difference(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Product(int num1, int num2)
    {
        return num1 * num2;
    }

    public static double Division(double num1, double num2)
    {
        return num1 / num2;
    }

    public static void ColoredText(string text)
    {
        int lenght = text.Length;
        while (lenght > 15)
        {
            lenght -= 15;
        }
        Console.ForegroundColor = (ConsoleColor)lenght;
        Console.Write(text);
        Console.ResetColor();
    }

    public static double ConvertToEUR(double baseMoney, string convType)
    {
        if (convType == "JPY") 
        {
            return baseMoney * 0.0061;
        }
        else if (convType == "USD") 
        {
            return baseMoney * 0.92;
        }
        else if (convType == "CHF") 
        {
            return baseMoney * 1.04;
        }
        else
        {
            return baseMoney;
        }
    }

    public static void WriteArrayToConsole<T>(this ICollection<T> items) where T : class
    {
        foreach (object item in items)
        {
            if (item != null)
            {
            Console.WriteLine(item.ToString());
            }
        }
    }

    public static void WriteTimeFormat(double lengthInSeconds)
    {
        double minutes = lengthInSeconds / 60;
        double seconds = lengthInSeconds % 60;

        Console.Write($"{minutes:F0}:{seconds:F0}");
    }
}