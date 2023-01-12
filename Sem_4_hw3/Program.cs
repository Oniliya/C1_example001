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

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i=0; i<count; i++)
    {
       if (i != count-1) Console.Write($"{array[i]},");
       else  Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}

void CreateArray(int[] arr, int len)
{
    for (int i = 0; i < len; i++)
    {
        int n = GetNumberFromUser($"Введите {i+1}е число ", "Ошибка ввода!");
        arr[i] = n; 
    }
}

int[] arr = new int[8];
CreateArray(arr,8);
PrintArray(arr);


