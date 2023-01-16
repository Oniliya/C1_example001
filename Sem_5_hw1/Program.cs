int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int Check(int[] arr)
{
    int kol=0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2==0) kol++;
    }
    return kol;
}

Console.Clear();
int[] array = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", array));

Console.Write("Количество четных элементов -> ");
Console.WriteLine(Check(array));

