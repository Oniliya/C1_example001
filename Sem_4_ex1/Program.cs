﻿static int Init_Digit()
{
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            return x;
            break;
        }
        Console.WriteLine("Ошибка ввода!");
    }
}

int Calc(int x)
{
    int count=0;
    while (x>0)
    {
        x=x/10;
        count++;
    }
    return count;
    }
    

int n=Init_Digit();
Console.Write($"{n}->");
int c=Calc(n);
Console.WriteLine(c);
