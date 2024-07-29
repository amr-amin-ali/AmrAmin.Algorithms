# Bucket Sort Algorithm

Bucket Sort is a comparison-based sorting algorithm that works by dividing the input array into a number of smaller sub-arrays, or "buckets", and then sorting each bucket individually before combining them back together to form the final sorted array.

## When to Use Bucket Sort

Bucket Sort is particularly effective when:

1. **Uniform Data Distribution**: The algorithm performs best when the input data is uniformly distributed across a range of values. If the data is not uniformly distributed, the performance of Bucket Sort may degrade.
2. **Large Input Range**: Bucket Sort is most efficient when the range of input values is significantly larger than the number of elements in the input array. This allows the algorithm to effectively distribute the elements into the buckets.
3. **Floating-Point Data**: Bucket Sort is well-suited for sorting floating-point data, as the uniform distribution of values is common in such data sets.

## How it Works

The Bucket Sort algorithm follows these steps:

1. **Determine the Number of Buckets**: The first step is to determine the number of buckets to use. This is typically based on the range of input values and the number of elements in the input array.
2. **Distribute the Elements into Buckets**: The input array is scanned, and each element is placed into a corresponding bucket based on its value.
3. **Sort the Buckets**: Each non-empty bucket is sorted individually, typically using another sorting algorithm like Insertion Sort or Quick Sort.
4. **Concatenate the Sorted Buckets**: The sorted buckets are then combined back into a single, sorted output array.

The key idea behind Bucket Sort is to leverage the uniform distribution of the input data to efficiently sort the elements. By dividing the input into smaller, more manageable sub-arrays (buckets), the algorithm can take advantage of the inherent structure of the data to perform the sorting process more effectively.

## Code Example

Here's an example implementation of the Bucket Sort algorithm in C#:

```csharp

public static class BucketSort
{

    public static void Sort(float[] array, int numberOfBuckets)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: "Bucket Sort Algorithm");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");

        List<List<float>> buckets = CreateBuckets(array: array, numberOfBuckets: numberOfBuckets);

        int i = 0;
        foreach (var buckket in buckets)
        {
            // sort the buckket
            buckket.Sort((a, b) => a.CompareTo(b));
            // insert into the main array
            foreach (var item in buckket)
            {
                array[i++] = item;
            }
        }


        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }

    private static List<List<float>> CreateBuckets(float[] array, int numberOfBuckets)
    {
        List<List<float>> buckets = new List<List<float>>();

        // Initialize the buckets
        for (int i = 0; i <= numberOfBuckets; i++)
        {
            buckets.Add(new List<float>());
        }

        foreach (var item in array)
        {
            var i = (int)item / numberOfBuckets;
            buckets[i].Add(item);
        }

        return buckets;
    }
}

```

The `Sort` method takes a floating-point array `array` and modifies it in-place to sort the array in ascending order.

## Usage Example

Here's an example of how to use the `BucketSort` method:

```csharp
float[] bucketSortArray = [1.5F, 9.4F, 5.2F, 6.1F, 3.9F, 7.7F, 4.1F, 2.2F, 8.5F];
BucketSort.Sort(array: bucketSortArray, numberOfBuckets: 3);

// The numbers array is now sorted:  {1.5, 2.2, 3.9, 4.1, 5.2, 6.1, 7.7, 8.5, 9.4}
```

You can call the `BucketSort` method with any floating-point array, and it will sort the array in ascending order.

## Time Complexity

The time complexity of Bucket Sort is shown in the following table:

| Metric     | Best Case | Worst Case |
|------------|-----------|------------|
| Distribution | O(n)     | O(n)       |
| Sorting buckets | O(n/b + b) | O(n^2/b + b) |
| Total      | O(n + b)  | O(n^2)     |
| Space      | O(n + b)  | O(n + b)   |

The best-case time complexity occurs when the input data is uniformly distributed, and the number of buckets is chosen optimally. In this case, the overall time complexity is O(n + b), where n is the size of the input array and b is the number of buckets.

The worst-case time complexity occurs when the input data is not uniformly distributed, and the number of buckets is not chosen optimally. In this case, the overall time complexity is O(n^2), which is the same as the time complexity of comparison-based sorting algorithms like Quicksort or Mergesort.

The space complexity of Bucket Sort is O(n + b), as it requires additional space to store the buckets and the sorted output array.

Bucket Sort is most effective when the input data is uniformly distributed and the range of input values is significantly larger than the number of elements in the input array. In these cases, Bucket Sort can outperform comparison-based sorting algorithms like Quicksort or Mergesort.