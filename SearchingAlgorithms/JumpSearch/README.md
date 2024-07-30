# Jump Search Algorithm

The Jump Search Algorithm is a searching algorithm used to find the position of a target value within a sorted array. It is a hybrid between the Linear Search Algorithm and the Binary Search Algorithm, combining the advantages of both approaches.

## How it Works

The Jump Search Algorithm works by first dividing the sorted array into equal-sized blocks. The algorithm then jumps from block to block, comparing the last element of each block with the target value, until it finds the block that contains the target value (or determines that the target value is not present in the array).

Once the correct block is found, the algorithm performs a linear search within that block to find the target value.

The steps of the Jump Search Algorithm are as follows:

1. Calculate the ideal block size, which is the square root of the number of elements in the array.
2. Start at the first element of the array.
3. Jump forward by the block size until the last element of the current block is greater than or equal to the target value.
4. Perform a linear search within the current block to find the target value.

## C# Implementation

Here's an example implementation of the Jump Search Algorithm in C#:

```csharp
public static int JumpSearch(int[] arr, int target)
{
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

    // Perform linear search within the block
    for (int i = start; i <= Math.Min(end, n - 1); i++)
    {
        if (arr[i] == target)
        {
            return i;
        }
    }

    return -1; // Target value not found
}
```

## Comparison with Linear Search

The Linear Search Algorithm is a simple and straightforward approach to finding a target value in an array. It works by iterating through the array element by element, comparing each element to the target value until the target is found or the end of the array is reached.

The time complexity of the Linear Search Algorithm is O(n), where n is the number of elements in the array. This means that the algorithm's running time grows linearly with the size of the input.

The Jump Search Algorithm, on the other hand, has a time complexity of O(√n), which is better than the Linear Search Algorithm's O(n). This is because the Jump Search Algorithm reduces the number of comparisons by jumping through the array in larger steps, and then performing a linear search within the correct block.

## Ideal Block Size

The ideal block size for the Jump Search Algorithm is the square root of the number of items in the array. This is because the square root function balances the time spent jumping between blocks and the time spent performing the linear search within each block.

If the block size is too small, the algorithm will have to perform more jumps, which will increase the total time complexity. If the block size is too large, the algorithm will have to perform more linear searches within each block, which will also increase the total time complexity.

By using the square root of the number of items in the array as the block size, the Jump Search Algorithm achieves the optimal balance between the time spent jumping and the time spent performing linear searches.

## Usage Examples

Here's an example of how to use the Jump Search Algorithm to find a target value in a sorted array:

```csharp
using System;

public class Program
{
    public static void Main()
    {
        // Define a sorted array
        int[] arr = { 1, 4, 7, 10, 15, 22, 30, 35, 40, 45, 50 };
        int target = 22;

        // Find the index of the target value using Jump Search
        int index = JumpSearch(arr, target);

        if (index == -1)
        {
            Console.WriteLine($"Target value {target} not found in the array.");
        }
        else
        {
            Console.WriteLine($"Target value {target} found at index {index}.");
        }
    }

    public static int JumpSearch(int[] arr, int target)
    {
        // Implementation of the Jump Search Algorithm as shown earlier
    }
}
```

In this example, we define a sorted array and a target value, and then use the Jump Search Algorithm to find the index of the target value in the array. The output of this program will be:

```
Target value 22 found at index 5.
```