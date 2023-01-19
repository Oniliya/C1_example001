float GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = float.TryParse(Console.ReadLine(), out float userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

bool CheckCoord(float x1, float x2, float y1, float y2)
{
    if (x1==x2) 
    {
        Console.WriteLine($"Прямые парралельны");
        return false;
    }

    if ((x1==x2)&&(y1==y2))
    {
        Console.WriteLine($"Прямые совпадают");
        return false;
    }
    return true;
}

void CoordPoint(float x1, float x2, float y1, float y2)
{
    Console.WriteLine($"Координата x точки перечечения {(y2-y1)/(x1-x2)}");
    Console.WriteLine($"Координата y точки перечечения {x1*(y2-y1)/(x1-x2)+y1}");
}

float b1=GetNumberFromUser($"Введите значение b1 ", "Ошибка ввода!");
float k1=GetNumberFromUser($"Введите значение k1 ", "Ошибка ввода!");
float b2=GetNumberFromUser($"Введите значение b2 ", "Ошибка ввода!");
float k2=GetNumberFromUser($"Введите значение k2 ", "Ошибка ввода!");

if (CheckCoord(k1,k2,b1,b2) ) CoordPoint(k1,k2,b1,b2);

