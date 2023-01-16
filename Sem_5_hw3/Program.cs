double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i=0; i<count; i++)
    {
       if (i != count-1) Console.Write($"{array[i]},");
       else  Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}





Console.Clear();
double[] array = GetArray(10, 1, 1000);
PrintArray(array);