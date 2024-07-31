namespace AmrAmin.Algorithms.Utils;
using System;

public static class StringManipulationUtils
{
    public static void PrintSearchHeader(string algorithmName)
    {
        Console.WriteLine(@"/============================================================\");
        if (algorithmName is not null)
        {
            Console.WriteLine($"|___________________{algorithmName}_________________|");
        }
    }

    public static void PrintContent(string content)
    {

        Console.WriteLine($"|\t\t{content}");
    }

    public static void PrintStringFooter()
    {
        Console.WriteLine("\\============================================================/\n\n\n");
    }
}
