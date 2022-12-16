Console.Write("Введите первое число = ");
int a1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число = ");
int a2 = int.Parse(Console.ReadLine()); 
Console.Write("Введите третье число = ");
int a3 = int.Parse(Console.ReadLine()); 

if ((a1>a2)&&(a1>a3))
{
    Console.WriteLine($"max = {a1}");
} 
if ((a2>a1)&&(a2>a3))
{
    Console.WriteLine($"max = {a2}");
} 
if ((a3>a1)&&(a3>a2))
{
    Console.WriteLine($"max = {a3}");
} 
if ((a1==a2)&&(a1==a3))
{
    Console.WriteLine("числа равны");
} 