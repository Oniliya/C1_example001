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

int[] GetArray(int size)
{
    int[] res = new int[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
    }
    return res;
}

int CheckArray(int[] arr)
{
    int kol=0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]>0) kol++;
    }
    return kol;
}

int n=GetNumberFromUser($"Введите количество чисел ", "Ошибка ввода!");
int[] mas=GetArray(n);
Console.WriteLine($"количество чисел больше 0 -> {CheckArray(mas)}");

