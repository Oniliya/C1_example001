static int Init_Digit()
{
    while (true)
    {
        Console.Write("Введите пятизначное число: ");
        if (int.TryParse(Console.ReadLine(), out int x)&&(x>9999)&&(x<100000))
        {
            return x;
            break;
        }
        Console.WriteLine("Ошибка ввода!");
    }
}

int n=Init_Digit();
Console.Write($"{n}->");

if ( ((n % 10)==(n / 10000)) && (((n/10)%10)==(n/1000)%10))
{
    Console.Write(" да ");
}
else
{
    Console.Write(" нет ");
}
