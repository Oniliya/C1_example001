int a;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    if ((int.TryParse(Console.ReadLine(), out a))&&(a>99)&&(a<1000))
    {
        int a2=(a%100)/10;
        Console.WriteLine($"{a} -> {a2}");
        break;
    }
    Console.WriteLine("Ошибка ввода!");
}

