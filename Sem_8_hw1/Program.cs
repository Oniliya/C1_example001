// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void OrderArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            for(int k=j+1; k<inArray.GetLength(1); k++)
            if (inArray[i,k]<inArray[i,j]) 
            {
                int ch=0;
                ch=inArray[i,j];
                inArray[i,j]=inArray[i,k];
                inArray[i,k]=ch;
            }
        }
    }
}

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк в массиве -> ","Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов в массиве -> ","Ошибка ввода");
int[,] array = GetArray(rows, columns, 0, 50);
PrintArray(array);
OrderArray(array);
Console.WriteLine();
PrintArray(array);
