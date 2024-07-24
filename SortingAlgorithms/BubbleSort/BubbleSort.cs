namespace AmrAmin.Algorithms.SortingAlgorithms.BubbleSort;
public class BubbleSort
{
    public static void Sort(int[] arr)
    {
        Console.WriteLine(@"/==============================================================\");
        PrintArray(arr: arr, title: "Bubble Sort Algorithm", message: "Array to sort:");
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        PrintArray(arr: arr, message: "Sorted array");
        Console.WriteLine(@"\==============================================================/");
    }

    private static void PrintArray(int[] arr, string message, string title = null)
    {
        if (title is not null)
        {
            Console.WriteLine($"|____________________{title}_____________________|");
        }
        Console.WriteLine($"|\t-{message}");
        Console.Write("|\t\t[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                Console.Write($"{arr[i]}");

            }
            else
            {
                Console.Write($"{arr[i]}, ");
            }
        }
        Console.Write("]\n");
    }
}
