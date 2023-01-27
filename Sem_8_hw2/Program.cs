// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] CreateSumArray(int m, int[,] fromArray)
{
    int[] result = new int [m];
    for(int i=0; i<fromArray.GetLength(0); i++)
    {
        int strSum =0;
        for(int j=0; j<fromArray.GetLength(1); j++) strSum+=fromArray[i,j];
        result[i]=strSum;
    }
    return result;
}

int FindMin(int[] fromArray)
{
    int minElem=fromArray[0];
    int minElemNumber=0;
    for(int i=0; i<fromArray.Length; i++)
    {
        if (fromArray[i]<minElem) 
        {
            minElem=fromArray[i];
            minElemNumber=i;
        }
    }
    return minElemNumber;
}

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк в массиве -> ","Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов в массиве -> ","Ошибка ввода");
int[,] array = GetArray(rows, columns, 0, 50);
PrintArray(array);
Console.WriteLine();
int[] strArray = CreateSumArray(rows, array);
Console.WriteLine($"Строка с минимальной суммой - {FindMin(strArray)+1}");

