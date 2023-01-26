



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

int[] FindMin(int[,] inArray)
{
    int[] result = new int[2];
    int minElem=inArray[0,0];
    for(int i=0; i<inArray.GetLength(0);i++)
    {
        for(int j=0; j<inArray.GetLength(1);j++)
        {
            if (minElem>inArray[i,j])
            {
                minElem=inArray[i,j];
                result[0]=i;
                result[1]=j;
            }
        }
    }
    return result;
}

int[,] GetNewArray(int[,] fromArray, int coord_i, int coord_j)
{
   int m=fromArray.GetLength(0)-1;
   int n=fromArray.GetLength(1)-1;
   Console.WriteLine(m);
   Console.WriteLine(n);
   Console.WriteLine($"{coord_i}*{coord_j}");
   int[,] result = new int[m, n];

   for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i < coord_i)&&(j < coord_j)) result[i, j] = fromArray[i,j];
            if ((i > coord_i)&&(j > coord_j)) result[i, j] = fromArray[i+1,j+1];
            
            if ((i < coord_i)&&(j > coord_j)) result[i, j] = fromArray[i,j+1];
            if ((i > coord_i)&&(j < coord_j)) result[i, j] = fromArray[i+1,j];
            // else if (i != coord_i) result[i, j] = fromArray[i+1,j];
            // else (j != coord_j)) result[i, j] = fromArray[i,j+1];

            Console.Write($"{result[i,j]} * ");
        }
    }
    return result;    
}

Console.Clear();
int rows=GetNumberFromUser($"Введите количество строк массива: ","Ошибка");
int columns=GetNumberFromUser($"Введите количество столбцов массива: ","Ошибка");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] CoordMin = FindMin(array);

Console.WriteLine($"{array[CoordMin[0],CoordMin[1]]}");
Console.WriteLine($"{CoordMin[0]}, {CoordMin[1]}");

int[,] newArray=GetNewArray(array, CoordMin[0], CoordMin[1]);
//PrintArray(newArray);




