﻿static void Dots_Coord(ref int x, ref int y)
{
    try
    {
        Console.Write("Введите координату X : ");
        x = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите координату Y : ");
        y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

int x1=0, y1=0, x2=0, y2=0;
Dots_Coord(ref x1, ref y1);
Dots_Coord(ref x2, ref y2);

double res=Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2));
Console.WriteLine($"{res}, ");
