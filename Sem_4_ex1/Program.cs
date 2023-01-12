int GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
        return userNumber;
        Console.WriteLine(errorMessage);
    }
}


int Calc(int x)
{
    int count=0;
    while (x>0)
    {
        x=x/10;
        count++;
    }
    return count;
}

int Calc2(int x)
{
    int mult=1;
    for (int i=1;i<=x;i++)
    {
        mult=mult*i;
    }
    return mult;
}    

int n = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
Console.Write($"{n}->");

int c=Calc(n);
Console.WriteLine(c);

int c2=Calc2(n);
Console.WriteLine(c2);