void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
       Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}

void CreateArray(int[] arr)
{
    
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,2); 
        //arr[i]=0;
    }
}

int[] arr = new int[8];
CreateArray(arr);
PrintArray(arr);


