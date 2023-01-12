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


int Calc(int x)
{
    int summa=0;
    while (x > 0)
    {
        summa=summa+x%10;
        x = x / 10;
    }
    return summa;
}


int n = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
Console.Write($"{n}->");

int c = Calc(n);
Console.WriteLine(c);

