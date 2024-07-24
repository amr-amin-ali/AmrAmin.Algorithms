namespace AmrAmin.Algorithms.SortingAlgorithms.SelectionSort;
public class SelectionSort
{
    public static void Sort(int[] array)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: "Selection Sort Algorithm");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");

        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = FindMinIndex(array, i, i);
            Swap(array, minIndex, i);
        }

        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }

    private static int FindMinIndex(int[] array, int i, int minIndex)
    {
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }

        return minIndex;
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
