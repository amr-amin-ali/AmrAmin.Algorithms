namespace AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.InsertionSort;
internal class InsertionSort
{
    public static void Sort(int[] array)
    {
        Utils.SortingUtils.PrintArrayHeader(algorithmName: "Insertion Sort Algorithm");
        Utils.SortingUtils.PrintArray(array: array, arrayDescription: "Array to sort:");

        for (int i = 1; i < array.Length; ++i)
        {
            int current = array[i];
            int j = i - 1;

            // Move elements of arr[0..i-1], that are greater than key, to one position ahead of their current position
            while (j >= 0 && array[j] > current)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }

        Utils.SortingUtils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.SortingUtils.PrintArrayFooter();

    }
}
