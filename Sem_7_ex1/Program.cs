//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

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













//Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// 
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i+j;
//         }
//     }
//     return result;
// }

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine() ?? "");
// int[,] array = CreateArray(rows, columns);
// PrintArray(array);

// //Задайте двумерный массив. 
// //Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// //
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void ChangeArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if ((i%2!=0)&&(j%2!=0)) inArray[i,j]=inArray[i,j]*inArray[i,j];
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine() ?? "");
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// ChangeArray(array);
// PrintArray(array);


//Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int CheckDiagon(int[,] inArray)
// {
//     int sum=0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (i==j) sum=sum+inArray[i,j];
//         }
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine() ?? "");
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.Write($"Сумма элементов главной диагонали = {CheckDiagon(array)}");


