namespace AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.QuickSort;
public static class QuickSort
{
    public static void Sort(int[] array)
    {
        Utils.SortingUtils.PrintArrayHeader(algorithmName: "  Quick Sort Algorithm  ");
        Utils.SortingUtils.PrintArray(array: array, arrayDescription: "Array to sort:");
        int start = 0;
        int end = array.Length - 1;
        QuickSortAlgorithm(array, start, end);

        Utils.SortingUtils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.SortingUtils.PrintArrayFooter();

    }

    private static void QuickSortAlgorithm(int[] array, int start, int end)
    {

        /*First we need to partition this array
         *  as a part of partitioning, the PIVOT which we assume is the last element in this array
         *  is going to move to it's right partition, then we gety the position of the PIVOT and from there
         *  we will recursively sort the left and right partition
         */

        // 0. condition to break the recursion
        if (start >= end)
        {
            return;
        }
        // 1. Partition
        var boundary = Partition(array: array, start: start, end: end);
        // 2. Sort left 
        QuickSortAlgorithm(array, start, boundary - 1);
        // 3. Sort right
        QuickSortAlgorithm(array, boundary + 1, end);



    }
    /// <summary>Implements the partitioning part of the algorithm.</summary>
    /// <returns>The index of the PIVOT after it has moved to it's right position.</returns>
    private static int Partition(int[] array, int start, int end)
    {
        // let's assume that the PIVOT is the last element in this array.
        var pivot = array[end];
        // we also need a variable and set it's value to -1 which mean that the left partition is empty.
        var boundary = start - 1;
        // now iterate over the array and if we found an item smaller than the PIVOT, we put it in the left partition.
        for (int i = start; i <= end; i++)
        {
            if (array[i] <= pivot)
            {
                //boundary++;
                //Swap(array, i, boundary);
                Swap(array, i, ++boundary);
            }
        }
        return boundary;
    }
    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
