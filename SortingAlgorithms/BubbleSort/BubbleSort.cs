namespace AmrAmin.Algorithms.SortingAlgorithms.BubbleSort;
public class BubbleSort
{
    public static void Sort(int[] arr)
    {
        Console.WriteLine(@"/==============================================================\");
        PrintArray(arr: arr, title: "Bubble Sort Algorithm", message: "Array to sort:");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[j - 1])
                {
                    // Swap arr[j] and arr[j+1]
                    Swap(arr, j, j - 1);
                }
            }
        }
        PrintArray(arr: arr, message: "Sorted array");
        Console.WriteLine(@"\==============================================================/");
    }

    private static void Swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
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
