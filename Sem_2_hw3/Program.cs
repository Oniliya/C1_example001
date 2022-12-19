int a;
while (true)
{
    Console.Write("Введите день недели: ");
    if ((int.TryParse(Console.ReadLine(), out a))&&(a>0)&&(a<8))
    {
        if ((a==6)||(a==7))
        {
            Console.WriteLine($"{a} -> да");
        }
        else
        {
            Console.WriteLine($"{a} -> нет");
        }
        break;
    }
    Console.WriteLine("Ошибка ввода!");
}

