// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] GetArray(int size)
{
    double[] res = new double[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble()*100;
    }
    return res;
}

double Max_Array(double[] arr)
{
    double max=arr[0];
    for (int i=0;i<arr.Length; i++)
    {
        if (arr[i]>max) max=arr[i];
    }
    return max;
}
double Min_Array(double[] arr)
{
    double min=arr[0];
    for (int i=0;i<arr.Length; i++)
    {
        if (arr[i]<min) min=arr[i];
    }
    return min;
}

Console.Clear();
double[] array = GetArray(10);
Console.WriteLine(String.Join(" ", array));
Console.Write($"Разница между максимальным и минимальным элементом массива = ");
Console.WriteLine("{0,6:F2}", Max_Array(array)-Min_Array(array));




