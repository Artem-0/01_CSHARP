// Программа, создающая массив чисел заданной длины и высчитывающая сумму и произведение его элементов
System.Console.WriteLine("Введите количество элементов массива: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] arr = new int[n];
// Вызов функций:
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
double product = GetProductOfElements(arr);
System.Console.WriteLine($"Сумма элементов: {sum}");
System.Console.WriteLine($"Произведение элементов: {product}");

// Функция заполнения массива:
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
}
// Функция вывода массива на экран:
void PrintArray(int[] arr)
{
    System.Console.Write("Заполненный массив: ");
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
    System.Console.WriteLine(" ");
}
// Функция вычисления суммы элементов массива:
int GetSumOfElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}
// Функция вычисления произведения элементов массива:
double GetProductOfElements(int[] arr)
{
    double product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        product = product * arr[i];
    }
    return product;
}