int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ShowInterest(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int value = matrix[i, j];
                int sum = 0;
                while (value > 0)
                {
                    sum = sum + value % 10;
                    value = value / 10;
                    if (sum % 2 == 0)
                    {
                        System.Console.Write(matrix[i, j] + " ");
                    }
                }
            }
        }
}


int[,] matrix = CreateMatrix(4, 5);
System.Console.WriteLine("Матрица:");
ShowMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine("Чётные элементы матрицы :");
ShowInterest(matrix);