# Bubble Sort Algorithm

Bubble Sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements and swaps them if they are in the wrong order. The pass through the list is repeated until the list is sorted.

## How it Works

1. Compare the first two elements in the list.
2. If the first element is greater than the second element, swap them.
3. Move to the next pair of elements and repeat step 2.
4. Repeat steps 1-3 until the entire list is sorted.

The algorithm gets its name from the way smaller or larger elements "bubble up" to the top of the list.

## Code Example

Here's an example implementation of the Bubble Sort algorithm in C#:

```csharp
public static void Sort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[j - 1])
            {
                Swap(arr, j, j - 1);
            }
        }
    }
}


private static void Swap(int[] arr, int index1, int index2)
{
    int temp = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = temp;
}

```

The `BubbleSort` method takes an integer array `arr` as input and sorts it in ascending order using the Bubble Sort algorithm.

The outer loop runs `n-1` times, where `n` is the length of the array. This is because after the first `n-1` passes, the last element will be in its correct position.

The inner loop runs `n-i-1` times, where `i` is the current iteration of the outer loop. This is because after each pass, the largest element in the unsorted portion of the array will "bubble up" to the end of the array, so we don't need to check it again.

Inside the inner loop, we compare adjacent elements and swap them if they are in the wrong order.

## Usage Example

Here's an example of how to use the `BubbleSort` method:

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };
BubbleSort(numbers);

// The numbers array is now sorted: { 1, 2, 5, 8, 9 }
```

You can call the `BubbleSort` method with any integer array, and it will sort the array in ascending order.

## Time Complexity

The time complexity of Bubble Sort is O(n^2), where n is the size of the input array, `so it is a very slow algorithm`. This is because the algorithm has two nested loops, and the number of comparisons and swaps grows quadratically with the size of the input.

While Bubble Sort is a simple and easy-to-understand algorithm, it is not very efficient for large datasets. For better performance, you may want to consider using other sorting algorithms, such as Quicksort, Mergesort, or Heapsort, which have better time complexities.

#### Here's the table representation of the Bubble Sort algorithm's time complexity:

| Metric     | Best Case | Worst Case |
|------------|-----------|------------|
| Passes     | O(1)       | O(n)       |
| Comparisons| O(n)       | O(n)       |
| Total      | O(n)       | O(n^2)     |
| Complexity | Linear     | Quadratic  |

This table clearly shows the time complexity of the Bubble Sort algorithm in terms of the number of passes, comparisons, and the overall time complexity. The best-case scenario has a linear time complexity, while the worst-case scenario has a quadratic time complexity.