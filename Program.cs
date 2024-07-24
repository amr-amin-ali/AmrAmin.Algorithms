using AmrAmin.Algorithms.SortingAlgorithms.BubbleSort;
using AmrAmin.Algorithms.SortingAlgorithms.SelectionSort;

public class Program
{
    public static void Main(string[] args)
    {
        /////////////////////////////////////////
        int[] arr1 = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        BubbleSort.Sort(arr1);
        /////////////////////////////////////////
        int[] arr2 = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        SelectionSort.Sort(arr2);
        /////////////////////////////////////////

    }
}