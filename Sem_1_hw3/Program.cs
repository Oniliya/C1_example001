Console.Write("Введите число = ");
int a1 = int.Parse(Console.ReadLine()); 

if (a1%2==0)
{
    Console.WriteLine($"{a1} - четное");
} 
else
{
    Console.WriteLine($"{a1} - не четное");
}