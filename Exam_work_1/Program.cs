// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

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

string[] CreateArray(int m)
{
    string[] result = new string[m];
    for(int i=0; i<result.GetLength(0); i++)
    {
        Console.Write($"Введите {i} строку массива -> ");
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i=0; i<arr.GetLength(0)-1; i++)
    {
        Console.Write($"\"{arr[i]}\",");
    }
    Console.Write($"{arr[arr.GetLength(0)-1]}\"]");
}

int check(string[] arr)
{
    int count=0;
    for (int i=0; i<arr.GetLength(0); i++)
    {
        if (arr[i].Length<4)
            count++;
    }
    return count;
}

Console.Clear();
int num = GetNumberFromUser("Введите количество строк в массиве -> ", "Ошибка ввода");
string[] array = CreateArray(num);
PrintArray(array);
string[] array2 = new string[check(array)];

PrintArray(array2);



