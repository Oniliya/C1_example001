static void InitQuaterByUser(ref int x)
{
    try
    {
        Console.Write("Введите Номер координатной четверти: ");
        x = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void PrintQuarterByCoords(int x)
{
    if(x==1)
        Console.WriteLine("x>0 and y>0");
    else if(x ==2)
        Console.WriteLine("x<0 and y>0");
    else if(x ==3)
        Console.WriteLine("x<0 and y<0");
    else if(x ==4)
        Console.WriteLine("x>0 and y<0");
    else
        Console.WriteLine("Такой четверти не существует");
}

int X = 0;
InitQuaterByUser(ref X); 
PrintQuarterByCoords(X); 