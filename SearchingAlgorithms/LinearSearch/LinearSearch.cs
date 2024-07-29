namespace AmrAmin.Algorithms.SearchingAlgorithms.LinearSearch;

using AmrAmin.Algorithms.Utils;

public static class LinearSearch
{
    public static int Search(int[] arr, int target)
    {
        SearchingUtils.PrintSearchHeader(" Linear Search");
        SearchingUtils.PrintArray(arr, "Array to search in:");
        SearchingUtils.PrintTarget(target);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(target))
            {
                SearchingUtils.PrintResult(i);
                SearchingUtils.PrintArrayFooter();
                return i;
            }
        }
        SearchingUtils.PrintResult(-1);
        SearchingUtils.PrintArrayFooter();
        return -1;
    }
}
