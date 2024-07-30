namespace AmrAmin.Algorithms.SearchingAlgorithms.BinarySearch;

using AmrAmin.Algorithms.Utils;

public static class BinarySearchIterative
{
    public static int Search(int[] arr, int target)
    {
        SearchingUtils.PrintSearchHeader(" Binary Search Iterative");
        SearchingUtils.PrintArray(arr, "Array to search in:");
        SearchingUtils.PrintTarget(target);



        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (arr[middle] == target)
            {
                SearchingUtils.PrintResult(middle);
                SearchingUtils.PrintArrayFooter();
                return middle; // Target found
            }

            else if (arr[middle] < target)
            {
                left = middle + 1; // Target is in the right half
            }
            else
            {
                right = middle - 1; // Target is in the left half
            }
        }
        SearchingUtils.PrintResult(-1);
        SearchingUtils.PrintArrayFooter();

        return -1; // Target not found
    }
}
