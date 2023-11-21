namespace System;

public static class SystemExtensions
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
}