int n = 10;
int[] arr = new int[n]; // или int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}