namespace AmrAmin.Algorithms.SearchingAlgorithms.JumpSearch;

using AmrAmin.Algorithms.Utils;

public static class JumpSearch
{
    public static void Search(int[] arr, int target)
    {
        SearchingUtils.PrintSearchHeader(" Jump Search");
        SearchingUtils.PrintArray(arr, "Array to search in:");
        SearchingUtils.PrintTarget(target);


        int n = arr.Length;
        int blockSize = (int)Math.Sqrt(n);
        int start = 0;
        int end = blockSize - 1;

        // Find the correct block
        while (end < n && arr[end] <= target)
        {
            start = end;
            end += blockSize;
        }
        int result = -1;
        // Perform linear search within the block
        for (int i = start; i <= Math.Min(end, n - 1); i++)
        {
            if (arr[i] == target)
            {
                result = i;
                break;
            }
        }

        SearchingUtils.PrintResult(result);// Target value not found
        SearchingUtils.PrintArrayFooter();
    }
}
