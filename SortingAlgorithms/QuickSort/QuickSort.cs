namespace AmrAmin.Algorithms.SortingAlgorithms.QuickSort;
public static class QuickSort
{
    public static void Sort(int[] array)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: "  Quick Sort Algorithm  ");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");

        QuickSortAlgorithm(array, 0, array.Length - 1);

        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }
    private static void QuickSortAlgorithm(int[] arr, int low, int high)
    {

        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSortAlgorithm(arr, low, pi - 1);
            QuickSortAlgorithm(arr, pi + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
