static void Dots_Coord(ref int x, ref int y, ref int z)
{
    try
    {
        Console.Write("Введите координату X : ");
        x = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите координату Y : ");
        y = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите координату Z : ");
        z = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

int x1=0, y1=0, x2=0, y2=0, z1=0, z2=0;

Dots_Coord(ref x1, ref y1, ref z1);
Dots_Coord(ref x2, ref y2, ref z2);

Double res=Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));

Console.Write($"A({x1},{y1},{z1});B({x2},{y2},{z2}) -> {res.ToString("0.00")}");

