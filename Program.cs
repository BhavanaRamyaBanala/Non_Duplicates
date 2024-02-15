// See https://aka.ms/new-console-template for more information
Console.WriteLine("Printing Non-Duplicates!!");
int i = 0, j = 0;
int[] arr1 = new int[] { 4,7,8,4,6,8, 3, 1, 1, 4, 2, 2,6 };
for (i = 0; i < arr1.Length; i++)
{
    for (j = 0; j < arr1.Length; j++)
    {
        if (i == j)
            continue;
        if (arr1[j] == arr1[i])
            break;
    }
    if (arr1.Length == j)
    {
        Console.Write(arr1[i] + " ");
    }
}
