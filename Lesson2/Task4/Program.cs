// int n = 10;
int[] arr = { 2, -8, -1, 6, 3 };

int i = 0;
int max = arr[i];

while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
System.Console.WriteLine($"{max}");

max = arr[0];
for(int j = 0; j < arr.Length; j++)
{
     if (arr[j] > max)
    {
        max = arr[j];
    }
}
System.Console.WriteLine($"{max}");

max = arr[0];
foreach(int e in arr)
{
     if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine($"{max}");