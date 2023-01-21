int[,] pic_line =new int[,]
{
    {0,0,0,0 },
    {0,0,0,0 },
    {0,0,0,0 },
    {1,1,1,1 },
};
int[,] pic_half_cross=new int[,]
{
    {0,0,0 },
    {0,1,0 },
    {1,1,1 },    
};
int[,] pic_cube=new int[,]
{
    {1,1 },
    {1,1 },
};
int[,] pic_z_right=new int[,]
{
    {1,1,0 },
    {0,1,1 },
    {0,0,0 }
};
int[,] pic_z_left=new int[,]
{
    {0,1,1 },
    {1,1,0 },
    {0,0,0 }
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
    for (int i=0; i<array.GetLength(0)-1; i++)
    {
        for (int j=0; j<array.GetLength(1)-i; j++)
        {
            // int ch=0;
            // ch=array[i,j];
            // array[i,j]=array[array.GetLength(0)-1-i,array.GetLength(1)-1-j];
            // array[array.GetLength(0)-1-i,array.GetLength(1)-1-j]=ch;
            (array[i,j], array[array.GetLength(0)-1-i,array.GetLength(1)-1-j])=(array[array.GetLength(0)-1-i,array.GetLength(1)-1-j], array[i,j]);

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
RotateTet_main(pic_line);
PrintArray(pic_line);

PrintArray(pic_half_cross);
RotateTet_main(pic_half_cross);
PrintArray(pic_half_cross);
RotateTet_second(pic_half_cross);
PrintArray(pic_half_cross);
RotateTet_main(pic_half_cross);
PrintArray(pic_half_cross);

PrintArray(pic_cube);

PrintArray(pic_z_right);
RotateTet_main(pic_z_right);
PrintArray(pic_z_right);
RotateTet_second(pic_z_right);
PrintArray(pic_z_right);
RotateTet_main(pic_z_right);
PrintArray(pic_z_right);