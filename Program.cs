using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.BubbleSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.InsertionSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.MergeSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.QuickSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.SelectionSort;
using AmrAmin.Algorithms.SortingAlgorithms.NonComparisonBasedSort;

public class Program
{
    public static void Main(string[] args)
    {
        /////////////////////////////////////////
        int[] bubbleSortArray = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        BubbleSort.Sort(bubbleSortArray);
        /////////////////////////////////////////
        int[] selectionSortArray = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        SelectionSort.Sort(selectionSortArray);
        /////////////////////////////////////////
        int[] insertionSortArray = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        InsertionSort.Sort(insertionSortArray);
        /////////////////////////////////////////
        int[] mergeSortArray = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        MergeSort.Sort(mergeSortArray);
        /////////////////////////////////////////
        int[] quickSortArray = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        QuickSort.Sort(quickSortArray);
        /////////////////////////////////////////
        int[] countingSortArray = [1, 9, 5, 6, 3, 7, 4, 2, 8];
        CountingSort.Sort(countingSortArray);
        /////////////////////////////////////////

    }
}