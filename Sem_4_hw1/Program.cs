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

int Calc(int x,int x1)
{
    int mult=1;
    for (int i=1;i<=x1;i++)
    {
        mult=mult*x;
    }
    return mult;
}

int a = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int b = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");

Console.Write($"{a},{b}->{Calc(a,b)}");