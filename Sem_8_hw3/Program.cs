// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultArray(int[,] a, int[,] b)
{
    int[,] c= new int [a.GetLength(0),b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
           c[i,j]=0;
           for (int k = 0; k < b.GetLength(0); k++) c[i,j]+=a[i,k]*b[k,j];
        }
    }
    return c;
}

Console.Clear();

int rows = GetNumberFromUser("Введите количество строк в первой матрице -> ","Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов в первой матрице -> ","Ошибка ввода");
int[,] array1 = GetArray(rows, columns, 0, 50);
Console.WriteLine($"Для произведения матриц количество строк во второй матрице равно уже указанному количеству столбцов в первой -> {columns}");
int columns2 = GetNumberFromUser("Введите количество столбцов во второй матрице -> ","Ошибка ввода");
int[,] array2 = GetArray(columns, columns2, 0, 50);

int[,] resultArray = MultArray(array1, array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(resultArray);
Console.WriteLine();



