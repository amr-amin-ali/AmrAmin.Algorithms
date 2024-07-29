namespace AmrAmin.Algorithms.Utils;
using System;

public static class Utils
{
    public static void PrintArrayHeader(string algorithmName)
    {
        Console.WriteLine(@"/==============================================================\");
        if (algorithmName is not null)
        {
            Console.WriteLine($"|____________________{algorithmName}__________________|");
        }
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

    public static void PrintArray(float[] array, string arrayDescription)
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
        Console.WriteLine("\\==============================================================/\n\n\n");
    }
}
