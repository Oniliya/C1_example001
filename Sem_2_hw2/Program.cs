int a;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    if ((int.TryParse(Console.ReadLine(), out a))&&(a>99))
    {
        int n=0;
        int a_save=a;
        while (n<2)
        {
            a=a/10;
            n++;
        }
        Console.WriteLine($"третья цифра справа налево {a_save} -> {a%10}");
     
        a=a_save;
        int a3=0;
        while (a>99)
        {
            a3=a%10;
            a=a/10;
        }

        //Console.WriteLine($"{a3}");
        Console.WriteLine($"третья цифра слева направо {a_save} -> {a3}");
        break;
    }
    Console.WriteLine("третьей цифры нет");

}

