Console.Write("Введите первое число = ");
int a1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число = ");
int b = int.Parse(Console.ReadLine()); 
if (a1==b*b)
{Console.WriteLine("да");} 
else 
{Console.WriteLine("нет");}


//Console.WriteLine($"{a} -> {a*a}");

Console.Write("Введите число = ");
int a = int.Parse(Console.ReadLine()); 
if ((a>0) && (a<8))
{
    if (a==1)
        Console.WriteLine("Понедельник");
    if (a==2)
        Console.WriteLine("Вторник");
    if (a==3)
        Console.WriteLine("Среда");
    if (a==4)
        Console.WriteLine("Четверг");
    if (a==5)
        Console.WriteLine("Пятница");
    if (a==6)
        Console.WriteLine("Суббота");
    if (a==7)
        Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Неправильное число");
}

//Console.WriteLine($"{a} -> {a*a}");

