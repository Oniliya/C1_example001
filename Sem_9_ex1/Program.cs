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
    int n=n1;
    if (n==0) return;
    else 
    {
        F_posl(n-1);
        Console.Write($"{n}, ");
    }
}

void F_posl2(int n1, int n2)
{
    int n=n2;
    
    if (n==n1-1) return;
    else 
    {
        F_posl2(n1,n-1);
        Console.Write($"{n}, ");    
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

int num = GetNumberFromUser("Введите число -> ","Ошибка ввода");
F_posl(num);
Console.WriteLine();

int num2 = GetNumberFromUser("Введите второе значение -> ","Ошибка ввода");
if (num2>num) F_posl2(num, num2);
else F_posl2(num2, num);
Console.WriteLine();

int num3 = GetNumberFromUser("Введите число -> ","Ошибка ввода");
Console.WriteLine($"{RecurrSum(num3)}");

int num4 = GetNumberFromUser("Введите число -> ","Ошибка ввода");
int num5 = GetNumberFromUser("Введите степень -> ","Ошибка ввода");
Console.WriteLine($"{MultReccur(num4, num5)}");
