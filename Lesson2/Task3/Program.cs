// int n = 10;
int[] arr = { 4, 3, 8, 16, 9, 2 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}