namespace AmrAmin.Algorithms.SortingAlgorithms.SelectionSort;
public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        Console.WriteLine(@"/==============================================================\");
        PrintArray(arr: arr, title: "Selection Sort Algorithm", message: "Array to sort:");

        for (int i = 0; i < arr.Length; i++)
        {
            int minIndex = FindMinIndex(arr, i, i);
            Swap(arr, minIndex, i);
        }

        PrintArray(arr: arr, message: "Sorted array");
        Console.WriteLine("\\==============================================================/\n\n\n");

    }

    private static int FindMinIndex(int[] arr, int i, int minIndex)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }

        return minIndex;
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
            Console.WriteLine($"|____________________{title}__________________|");
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
