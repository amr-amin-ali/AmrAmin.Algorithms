using AmrAmin.Algorithms.SearchingAlgorithms.BinarySearch;
using AmrAmin.Algorithms.SearchingAlgorithms.JumpSearch;
using AmrAmin.Algorithms.SearchingAlgorithms.LinearSearch;
using AmrAmin.Algorithms.SearchingAlgorithms.TernarySearch;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.BubbleSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.InsertionSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.MergeSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.QuickSort;
using AmrAmin.Algorithms.SortingAlgorithms.ComparisonBasedSort.SelectionSort;
using AmrAmin.Algorithms.SortingAlgorithms.NonComparisonBasedSort.BucketSort;
using AmrAmin.Algorithms.SortingAlgorithms.NonComparisonBasedSort.CountingSort;

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
        float[] bucketSortArray = [1.5F, 9.4F, 5.2F, 6.1F, 3.9F, 7.7F, 4.1F, 2.2F, 8.5F];
        BucketSort.Sort(array: bucketSortArray, numberOfBuckets: 3);
        //SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH 
        //SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH 
        //SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH 
        //SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH 
        //SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH 
        //SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH SEARCH 
        int[] linearSearchArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        LinearSearch.Search(linearSearchArray, 7);
        LinearSearch.Search(linearSearchArray, 7);
        /////////////////////////////////////////
        int[] binarySearchIterativeArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        BinarySearchIterative.Search(binarySearchIterativeArray, 7);
        /////////////////////////////////////////
        int[] binarySearchRecursive = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        BinarySearchRecursive.Search(binarySearchRecursive, 5);
        /////////////////////////////////////////
        int[] ternarySearchArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        TernarySearch.Search(ternarySearchArray, 3);
        /////////////////////////////////////////
        int[] jumpSearchArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        JumpSearch.Search(jumpSearchArray, 6);
        /////////////////////////////////////////

    }
}