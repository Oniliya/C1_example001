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

int RecurrSum(int n1, int n2)
{
    if (n1 == n2) return n1;
    else
    {
        return n1 + RecurrSum(n1+1 ,n2);
    }

}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int num = GetNumberFromUser("Введите первое значение -> ", "Ошибка ввода");
int num2 = GetNumberFromUser("Введите второе значение -> ", "Ошибка ввода");
if (num2 > num) Console.WriteLine($"{RecurrSum(num, num2)}");
else Console.WriteLine($"{RecurrSum(num2, num)}");
Console.WriteLine();


