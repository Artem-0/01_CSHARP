string GetNumbersFromString(string s)
{
    string numbers = "";
    foreach(char e in s)
    {
        if (char.IsAsciiLetter(e) == false)
        {
            numbers = numbers + e;
        }
    }
    return numbers;
}

string? str = Console.ReadLine();
string? NumbersString = GetNumbersFromString(str);
// Console.WriteLine(NumbersString);

int[] arr = new int[NumbersString.Length];
int Numbers = Convert.ToInt32(NumbersString);
// System.Console.WriteLine(Numbers);

int[] ArrayFromNumbers = CreateArrayFromNumbers(arr);
PrintArrayFromNumbers(ArrayFromNumbers);

int[] CreateArrayFromNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[arr.Length -1 - i] = Numbers % 10;
        Numbers = Numbers / 10;
    }
    return arr;
}

void PrintArrayFromNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}