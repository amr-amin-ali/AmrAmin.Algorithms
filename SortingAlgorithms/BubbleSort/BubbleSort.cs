namespace AmrAmin.Algorithms.SortingAlgorithms.BubbleSort;
public class BubbleSort
{
    public static void Sort(int[] arr)
    {
        Console.WriteLine(@"/==============================================================\");
        PrintArray(arr: arr, title: "Bubble Sort Algorithm", message: "Array to sort:")

        bool isSorted;// Variable to break the loop as early as the array is already sorted instead of looping till the end in all cases
        for (int i = 0; i < arr.Length; i++)
        {
            isSorted = true;
            for (int j = 1; j < arr.Length - i; j++)
            {
                if (arr[j] < arr[j - 1])
                {
                    Swap(arr, j, j - 1);
                    // Swap occured, so array is not sorted
                    isSorted = false;
                }
            }
            if (isSorted)
            {
                break;
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
