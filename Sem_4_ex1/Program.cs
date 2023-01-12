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
Console.Write($"{n}->");
int count=0;
while (n>0)
{
    n=n/10;
    count++;
}
Console.WriteLine(count);
