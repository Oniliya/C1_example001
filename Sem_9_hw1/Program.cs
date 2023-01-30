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

void F_posl2(int n1, int n2)
{
    if (n2 == n1 - 1) return;
    else
    {
        Console.Write($"{n2}, ");
        F_posl2(n1, n2 - 1);
    }
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = GetNumberFromUser("Введите первое значение -> ", "Ошибка ввода");
int num2 = GetNumberFromUser("Введите второе значение -> ", "Ошибка ввода");
if (num2 > num) F_posl2(num, num2);
else F_posl2(num2, num);
Console.WriteLine();


