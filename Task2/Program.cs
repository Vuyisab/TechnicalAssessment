
static string FindMajorityElement(int[] arr)
{
    int candidate = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (count == 0)
        {
            candidate = arr[i];
            count = 1;
        }
        else if (arr[i] == candidate)
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    count = 0;
    foreach (int num in arr)
    {
        if (num == candidate) count++;
    }

    if (count > arr.Length / 2) return candidate.ToString();
    else return "No majority element";
}

int[] arr = { 3, 3, 4, 2, 4, 2, 2 };
Console.WriteLine(FindMajorityElement(arr));