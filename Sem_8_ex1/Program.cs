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

void FillStringFromArray(int[,] inArray, string[] res)
{
    int k=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {

            res[k]=inArray[i,j].ToString();
            k++;

        }
    }
}

string[] CreateStrArray(int col)
{
    string[] result = new string[col];
    for (int i = 0; i < col; i++)
    {
        result[i]=string.Empty;
    }
    return result;
}

void DelTwinsFromString(string[] str)
{
    for(int i=0; i<str.Length; i++)
    {
        for(int j=i+1; j<str.Length; j++)
        {
            if (str[i]==str[j]) str[j]=string.Empty;
        }
    }
}

int Check(int[,] inArray, int exampl)
{
    int kol=0;
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            if (inArray[i,j]==exampl) kol++;
        }
    }
    return kol;
}


Console.Clear();
int rows=GetNumberFromUser($"Введите количество строк массива: ","Ошибка");
int columns=GetNumberFromUser($"Введите количество столбцов массива: ","Ошибка");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();


string[] numbers = CreateStrArray(rows*columns);
FillStringFromArray(array, numbers);
DelTwinsFromString(numbers);

Console.WriteLine();
for (int i=0; i<numbers.Length; i++)
{
   if (numbers[i] != "" ) Console.WriteLine($"{int.Parse(numbers[i])} встречается {Check(array, int.Parse(numbers[i]))} раз"); 
}
















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
//     for(int j=0; j<inArray.GetLength(1); j++)
//     {
//         int ch=0;
//         ch=inArray[0, j];
//         inArray[0, j]=inArray[inArray.GetLength(0)-1, j];
//         inArray[inArray.GetLength(0)-1,j]=ch;
//         //(inArray[0,j], inArray[inArray.GetLength(0)-1,j])=(inArray[inArray.GetLength(0)-1,j], inArray[0,j]);
//     }
// }
// int GetNumberFromUser(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//         if (isCorrect)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }


// Console.Clear();
// int rows=GetNumberFromUser($"Введите количество строк массива: ","Ошибка");
// int columns=GetNumberFromUser($"Введите количество столбцов массива: ","Ошибка");
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// ChangeArray(array);
// PrintArray(array);





// Console.WriteLine();
// CheckSwopArray(array);
// PrintArray(array);

// void CheckSwopArray(int[,] inArray)
// {
//     if (inArray.GetLength(0)==inArray.GetLength(0))
//     {
//         for (int i=0; i<inArray.GetLength(0); i++)
//         {
//             for (int j=i+1; j<inArray.GetLength(1); j++)
//             {
//                 // int ch=0;
//                 // ch=inArray[i,j];
//                 // inArray[i,j]=inArray[j,i];
//                 // inArray[j,i]=ch;
//                 (inArray[i,j], inArray[j,i])=(inArray[j,i], inArray[i,j]);

//             }
//         }
//     }
//     else Console.WriteLine($"в матрице разные размерности");

// }





























// int GetNumberFromUser(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//         if (isCorrect)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }


// double[,] GetArray(int m, int n)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*100-50;
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write(string.Format("{0:F1}", inArray[i,j]));
//             Console.Write(" ");
//         }
//         Console.WriteLine();
//     }
// }

// //Задайте двумерный массив размером m×n, 
// //заполненный случайными целыми числами
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine() ?? "");
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

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