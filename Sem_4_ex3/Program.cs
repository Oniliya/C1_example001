static int Init_Digit()
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
    int mult=1;
    for (int i=1;i<=x;i++)
    {
        mult=mult*i;
    }
    return mult;
}
    

int n=Init_Digit();
Console.Write($"{n}->");

int c=Calc(n);
Console.WriteLine(c);
