// Console.Write("Введите X: ");
// int X = int.Parse(Console.ReadLine());
// Console.Write("Введите Y: ");
// int Y = int.Parse(Console.ReadLine());
// if(X > 0 && Y > 0)
// {
//     Console.WriteLine("1");
// }
// else if(X < 0 && Y > 0)
// {
//     Console.WriteLine("2");
// }
// else if(X < 0 && Y < 0)
// {
//     Console.WriteLine("3");
// }
// else if(X > 0 && Y < 0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Ошибка! Точка попадает на оси координат!");
// }


static void InitCoordinatesByUser(ref int x, ref int y)
{
    try
    {
        Console.Write("Введите X: ");
        x = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void PrintQuarterByCoords(int x, int y)
{
    if(x > 0 && y > 0)
        Console.WriteLine("1");
    else if(x < 0 && y > 0)
        Console.WriteLine("2");
    else if(x < 0 && y < 0)
        Console.WriteLine("3");
    else if(x > 0 && y < 0)
        Console.WriteLine("4");
    else
        Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}

int X = 0, Y = 0;

InitCoordinatesByUser(ref X, ref Y); 
PrintQuarterByCoords(X, Y);