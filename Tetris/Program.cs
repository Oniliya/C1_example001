char[,] pic =new char[,]
{
    {'.', '.', '.', '.' },
    {'.', '.', '.', '.' },
    {'.', '.', '.', '.' },
    {'#', '#', '#', '#' },
};

void PrintArray(char[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void RotateTet(char[,] array)
{
    char ch='/';
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            ch=array[i,j];
            array[i,j]=array[j,i];
            array[j,i]=ch;
        }
    }
}
// void PressKey()
// {

// }

Console.Clear();
PrintArray(pic);
RotateTet(pic);
//PrintArray(pic);

