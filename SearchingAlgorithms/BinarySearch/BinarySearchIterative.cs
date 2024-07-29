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
            int mid = left + ((right - left) / 2);

            if (arr[mid] == target)
            {
                SearchingUtils.PrintResult(mid);
                SearchingUtils.PrintArrayFooter();
                return mid; // Target found
            }

            else if (arr[mid] < target)
            {
                left = mid + 1; // Target is in the right half
            }
            else
            {
                right = mid - 1; // Target is in the left half
            }
        }
        SearchingUtils.PrintResult(-1);
        SearchingUtils.PrintArrayFooter();

        return -1; // Target not found
    }
}
