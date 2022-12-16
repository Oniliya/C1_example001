Console.Write("Введите первое число = ");
int a1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число = ");
int a2 = int.Parse(Console.ReadLine()); 
if (a1>a2)
{
    Console.WriteLine($"max = {a1}");
} 
else 
{
    if (a1==a2)
    {
        Console.WriteLine($"{a1}={a2}");
    }
    else
    {
        Console.WriteLine($"max = {a2}");
    }
}
