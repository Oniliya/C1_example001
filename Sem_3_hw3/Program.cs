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

int n=Init_Digit();

int index=1;
Console.Write($"{n}->");

while (index<=n)
{
    Console.Write($"{Math.Pow(index,3)}, ");
    index++;
}

