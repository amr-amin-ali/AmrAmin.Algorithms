# Ternary Search Algorithm

The Ternary Search Algorithm is a technique for finding the minimum or maximum of a unimodal function, which is a function that has a single minimum or maximum value within a given interval. It is a variation of the Binary Search Algorithm, which is a well-known algorithm for finding the target value in a sorted array.

## How it Works

The Ternary Search Algorithm works by repeatedly dividing the search interval into three parts and then selecting the appropriate third in which the minimum or maximum value must lie. The algorithm proceeds as follows:

1. Initialize the search interval to `[left, right]`.
2. Divide the interval into three equal parts by computing `mid1` and `mid2`:
   - `partitionSize = (right - left) / 3`
   - `mid1 = left + partitionSize`
   - `mid2 = right - partitionSize`
3. Evaluate the function at `mid1` and `mid2`.
4. If the function value at `mid1` is greater than the function value at `mid2`, the minimum (or maximum) must lie in the interval `[left, mid2]`. Update the search interval to `[left, mid2]`.
5. If the function value at `mid1` is less than the function value at `mid2`, the minimum (or maximum) must lie in the interval `[mid1, right]`. Update the search interval to `[mid1, right]`.
6. If the function value at `mid1` is equal to the function value at `mid2`, the minimum (or maximum) must lie in the interval `[mid1, mid2]`. Update the search interval to `[mid1, mid2]`.
7. Repeat steps 2-6 until the search interval is smaller than a specified tolerance.

## C# Implementation

Here's an example implementation of the Ternary Search Algorithm in C#:

```csharp
public static int TernarySearchAlgorithm(int[] array, int target, int left, int right)
{
    // Recursion stopping condition
    if (left > right)
    {
        return -1;
    }

    // first: calculate the middle points
    var partitionSize = (right - left) / 3;
    var mid1 = left + partitionSize;
    var mid2 = right - partitionSize;

    if (array[mid1] == target)
    {
        return mid1;
    }
    if (array[mid2] == target)
    {
        return mid2;
    }

    if (target < array[mid1])
    {
        return TernarySearchAlgorithm(array, target, left, mid1 - 1);
    }
    if (target > array[mid2])
    {
        return TernarySearchAlgorithm(array, target, mid2 + 1, right);
    }
    return TernarySearchAlgorithm(array, target, mid1 + 1, mid2 - 1);
}
```


## Comparison with Binary Search

The Binary Search Algorithm is a more efficient algorithm than the Ternary Search Algorithm for finding the target value in a sorted array. This is because the Binary Search Algorithm divides the search interval in half at each step, while the Ternary Search Algorithm divides the search interval into three parts.

The number of comparisons required by the Binary Search Algorithm to find the target value in a sorted array of size `n` is `log2(n)`, while the number of comparisons required by the Ternary Search Algorithm is `log3(n)`. Since `log2(n) < log3(n)`, the Binary Search Algorithm is faster than the Ternary Search Algorithm for finding the target value in a sorted array.

However, the Ternary Search Algorithm can be more efficient than the Binary Search Algorithm for finding the minimum or maximum of a unimodal function, as it can often converge to the solution more quickly. This is because the Ternary Search Algorithm can eliminate a larger portion of the search interval at each step, as it divides the interval into three parts instead of two.

## Usage Examples

Here's an example of how to use the Ternary Search Algorithm to find the minimum of a function:

```csharp
using System;

public class Program
{
    public static void Main()
    {
        int[] ternarySearchArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        TernarySearch.Search(ternarySearchArray, 3);
    }
```
