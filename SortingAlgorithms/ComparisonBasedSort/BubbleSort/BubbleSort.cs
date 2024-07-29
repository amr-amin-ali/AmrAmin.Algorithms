namespace AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.BubbleSort;
public class BubbleSort
{
    public static void Sort(int[] array)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: "Bubble Sort Algorithm");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");

        bool isSorted;// Variable to break the loop as early as the array is already sorted instead of looping till the end in all cases
        for (int i = 0; i < array.Length; i++)
        {
            isSorted = true;
            for (int j = 1; j < array.Length - i; j++)
            {
                if (array[j] < array[j - 1])
                {
                    Swap(array, j, j - 1);
                    // Swap occured, so array is not sorted
                    isSorted = false;
                }
            }
            if (isSorted)
            {
                break;
            }
        }
        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
