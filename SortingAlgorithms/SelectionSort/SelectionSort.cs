namespace AmrAmin.Algorithms.SortingAlgorithms.SelectionSort;
public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        Console.WriteLine(@"/==============================================================\");
        PrintArray(arr: arr, title: "Selection Sort Algorithm", message: "Array to sort:");

        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        PrintArray(arr: arr, message: "Sorted array");
        Console.WriteLine("\\==============================================================/\n\n\n");

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
