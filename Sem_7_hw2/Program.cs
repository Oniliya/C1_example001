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

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*100-50;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:F1}", inArray[i,j]));
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

bool CheckElementFormUser(int i1, int j1, double[,] inArray)
{
    if ((i1>=0)&&(i1<inArray.GetLength(0))&&(j1>=0)&&(j1<inArray.GetLength(1))) return true; 
    else return false;
}

Console.Clear();
int rows=GetNumberFromUser($"Введите количество строк матрицы ", "Ошибка ввода!");
int columns=GetNumberFromUser($"Введите количество столбцов матрицы ", "Ошибка ввода!");

double[,] array = GetArray(rows, columns);
PrintArray(array);

int asked_row=GetNumberFromUser($"Введите номер строки вашего элемента ", "Ошибка ввода!");
int asked_column=GetNumberFromUser($"Введите номер столбца вашего элемента ", "Ошибка ввода!");

if (CheckElementFormUser(asked_row,asked_column,array)) 
{
    Console.Write($"элемент {asked_row},{asked_column} в массиве есть -> ");
    Console.WriteLine(string.Format("{0:F1}", array[asked_row,asked_column]));
}
else Console.WriteLine($"элемента {asked_row},{asked_column} в массиве нет");



