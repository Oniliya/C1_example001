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

void F_posl(int n1)
{
    if (n1==0) return;
    else 
    {
        
        F_posl(n1-1);
        Console.Write($"{n1}, ");    
    }
}

void F_posl2(int n1, int n2)
{
    if (n2==n1-1) return;
    else 
    {
        F_posl2(n1,n2-1);
        Console.Write($"{n2}, ");    
    }
}

int RecurrSum(int n3)
{
    if (n3==0) return 0;
    else 
    {
        return n3%10+RecurrSum(n3/10);
    }

}

int MultReccur(int x, int y)
{
    if (y==1) return x;
    else
    {
        return x*MultReccur(x,y-1);
    }
}

//
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
//
int num = GetNumberFromUser("Введите число -> ","Ошибка ввода");
F_posl(num);
Console.WriteLine();

//
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
//
int num2 = GetNumberFromUser("Введите второе значение -> ","Ошибка ввода");
if (num2>num) F_posl2(num, num2);
else F_posl2(num2, num);
Console.WriteLine();

//
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
//
int num3 = GetNumberFromUser("Введите число -> ","Ошибка ввода");
Console.WriteLine($"{RecurrSum(num3)}");

//
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
//
int num4 = GetNumberFromUser("Введите число -> ","Ошибка ввода");
int num5 = GetNumberFromUser("Введите степень -> ","Ошибка ввода");
Console.WriteLine($"{MultReccur(num4, num5)}");
