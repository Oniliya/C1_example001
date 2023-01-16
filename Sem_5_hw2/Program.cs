int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int Sum_Array(int[] arr)
{
    int sum=0;
    for (int i=0;i<arr.Length; i++)
    {
        if (i%2==1) sum=sum+arr[i];
    }
    return sum;
}

Console.Clear();
int[] array = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine($"Сумма элементов на четных местах ={Sum_Array(array)} ");
