int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
foreach (int i in arr)
{
    Console.Write(i + " ");
}
Console.WriteLine();
int num = 0;
int count = 0;

foreach (int i in arr)
{
    int temp_num = i;
    int temp_count = 0;

    foreach (int j in arr)
    {
        if (j == temp_num)
        { temp_count++; }
        if (temp_count > count)
        {
            num = temp_num;
            count = temp_count;
        }
    }
}
Console.WriteLine("The most frequent number in the array is " + num);