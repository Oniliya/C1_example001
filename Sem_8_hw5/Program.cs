// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] GetArray(int n)
{
    int[,] result = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = 0;
        }
    }
    //внешняя часть матрицы
    int globalCount=1;
    //rigth
    for (int i = 0; i < n; i++)
    {
        result[0,i]=globalCount;
        globalCount++;
    }
    //down
    for (int i = 1; i < n; i++)
    {
        result[i,n-1]=globalCount;
        globalCount++;
    }
    //left
    for (int i = n-2; i >=0 ; i--)
    {
        result[n-1,i]=globalCount;
        globalCount++;
    }
    //up
    for (int i = n-2; i >0 ; i--)
    {
        result[i,0]=globalCount;
        globalCount++;
    }
    //внутренняя часть матрицы
    int ii=1; 
    int jj=1;
    while (globalCount<n*n)
    {
        //right
        while (result[ii,jj+1]==0)
        {
            result[ii,jj]=globalCount;
            globalCount++;
            jj++;
        }
        //down
        while (result[ii+1,jj]==0)
        {
            result[ii,jj]=globalCount;
            globalCount++;
            ii++;
        }
        //left
        while (result[ii,jj-1]==0)
        {
            result[ii,jj]=globalCount;
            globalCount++;
            jj--;
        }
        //up
        while (result[ii-1,jj]==0)
        {
            result[ii,jj]=globalCount;
            globalCount++;
            ii--;
        }
    }
    //центральный элемент
    for (int i = 0; i < n; i++) for (int j = 0; j < n; j++) if (result[i,j]==0) result[i,j]=globalCount;

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j]<10) Console.Write($"0{inArray[i, j]} ");
            else Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}



Console.Clear();

int rows = GetNumberFromUser("Введите количество строк и столбцов в матрице -> ","Ошибка ввода");
int[,] array = GetArray(rows);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();



