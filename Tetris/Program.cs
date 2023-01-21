int[,] pic_line =new int[,]
{
    {0,0,0,0 },
    {0,0,0,0 },
    {0,0,0,0 },
    {1,1,1,1 },
};

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j]==1) Console.Write($"*");
            else Console.Write($" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void RotateTet_main(int[,] array)
{    
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=i+1; j<array.GetLength(1); j++)
        {
            // int ch=0;
            // ch=array[i,j];
            // array[i,j]=array[j,i];
            // array[j,i]=ch;
            (array[i,j], array[j,i])=(array[j,i], array[i,j]);

        }
    }
}

void RotateTet_second(int[,] array)
{   
    int i=0;
    for (i=array.GetLength(0)-i; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            // int ch=0;
            // ch=array[i,j];
            // array[i,j]=array[j,i];
            // array[j,i]=ch;
            (array[i,j], array[array.GetLength(0)+1-i,array.GetLength(1)+1-j])=(array[array.GetLength(0)+1-i,array.GetLength(1)+1-j], array[i,j]);

        }
    }
}

// void PressKey()
// {

// }

Console.Clear();
PrintArray(pic_line);
RotateTet_main(pic_line);
PrintArray(pic_line);
RotateTet_second(pic_line);
PrintArray(pic_line);
