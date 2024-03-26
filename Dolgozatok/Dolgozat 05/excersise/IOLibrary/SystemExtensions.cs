namespace System;

public static class SystemExtensions
{
    public static void WriteToConsole(this object number)
    {
        Console.Write(number);
    }

    public static void WriteCollectionToConsole<T>(this ICollection<T> collectionToDisplay)
    {
        foreach (object item in collectionToDisplay)
        {
            Console.WriteLine(item);
        }
    }
}
