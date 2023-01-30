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
int power (int y, int x)
{
    int mult=y;
    if (x==0) return 1;
    else 
    {
        for (int i=1; i<=x; i++)
        {
            mult=mult*y;
        }
        return mult;
    }
}

int RecurrAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m == 1) return 2 + n;
    if (m == 2) return 2*n + 3;
    if (m == 3) return power(2, n+3) - 3;
    //if ((m>0)&&(n>0)) return RecurrAkkerman(m-1,RecurrAkkerman(m,n-1));
}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int num_m = GetNumberFromUser("Введите значение m -> ", "Ошибка ввода");
int num_n = GetNumberFromUser("Введите значение n -> ", "Ошибка ввода");
Console.WriteLine($"{RecurrAkkerman(num_m,num_n)}");

Console.WriteLine();