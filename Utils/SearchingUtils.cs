namespace AmrAmin.Algorithms.Utils;
using System;

public static class SearchingUtils
{
    public static void PrintSearchHeader(string algorithmName)
    {
        Console.WriteLine(@"/============================================================\");
        if (algorithmName is not null)
        {
            Console.WriteLine($"|___________________{algorithmName}_________________|");
        }
    }

    public static void PrintResult(int result)
    {
        Console.WriteLine($"|\t-Result:\t{result}");
    }
    public static void PrintTarget(int target)
    {
        Console.WriteLine($"|\t-Searching for:  {target}");

    }

    public static void PrintArray(int[] array, string arrayDescription)
    {
        if (arrayDescription is not null)
        {
            Console.WriteLine($"|\t-{arrayDescription}");
        }

        Console.Write("|\t\t[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write($"{array[i]}");

            }
            else
            {
                Console.Write($"{array[i]}, ");
            }
        }
        Console.Write("]\n");

    }

    public static void PrintArrayFooter()
    {
        Console.WriteLine("\\============================================================/\n\n\n");
    }
}
