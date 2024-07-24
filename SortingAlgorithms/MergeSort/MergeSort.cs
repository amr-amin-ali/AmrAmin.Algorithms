namespace AmrAmin.Algorithms.SortingAlgorithms.MergeSort;
public static class MergeSort
{


    public static void Sort(int[] array)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: "  Merge Sort Algorithm  ");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");

        MergeSortAlgorithm(array);

        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }

    private static void MergeSortAlgorithm(int[] array)
    {
        // if array has single element, then it is already sorted.
        // if array has single element, then it is already sorted.
        if (array.Length < 2)
        {
            return;
        }

        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        for (int i = middle; i < array.Length; i++)
        {
            right[i - middle] = array[i];
        }

        MergeSortAlgorithm(left);
        MergeSortAlgorithm(right);

        Merge(array, left, right);

    }

    private static void Merge(int[] result, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[k++] = left[i++];
            }
            else
            {
                result[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            result[k++] = left[i++];
        }

        while (j < right.Length)
        {
            result[k++] = right[j++];
        }
    }
}