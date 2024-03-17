


static void Sort(int[] arr)
{
    if (arr == null || arr.Length == 0)
    {
        return; // Exit the function if the array is empty or null.
    }

    int low = 0, mid = 0, high = arr.Length - 1;
    int temp;

    while (mid <= high)
    {
        switch (arr[mid])
        {
            case 0:
                temp = arr[low];
                arr[low] = arr[mid];
                arr[mid] = temp;
                low++;
                mid++;
                break;
            case 1:
                mid++;
                break;
            case 2:
                temp = arr[high];
                arr[high] = arr[mid];
                arr[mid] = temp;
                high--;
                break;
        }
    }
}


int[] arr = { 2, 1, 0, 1, 2, 1, 0 };
Console.WriteLine($"Original Arra: {string.Join(", ", arr)}");
Sort(arr);
Console.WriteLine("Sorted Array: " + string.Join(", ", arr));