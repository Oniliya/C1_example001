static void Init_Digit(ref int x)
{
    try
    {
        Console.Write("Введите число: ");
        x = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

int N=0;
Init_Digit(ref N);
int index=1;
Console.Write($"{N}->");
while (index<N)
{
    Console.Write($"{index*index}, ");
    index++;
}
Console.Write($"{index*index}. ");