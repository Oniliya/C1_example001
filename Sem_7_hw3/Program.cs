int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageByColomns(int[,] inArray)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum=0.0;
        for (int i = 0; i < inArray.GetLength(0); i++)    
        {
            sum+=inArray[i,j];
        }
        Console.Write($"{sum/inArray.GetLength(0)}; ");
    }
}

Console.Clear();
int rows=GetNumberFromUser($"Введите количество строк матрицы ", "Ошибка ввода!");
int columns=GetNumberFromUser($"Введите количество столбцов матрицы ", "Ошибка ввода!");
int[,] array=GetArray(rows, columns, 0, 9);
PrintArray(array);

AverageByColomns(array);