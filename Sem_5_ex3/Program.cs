//
//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int Kol_Array(int[] arr)
{
    int kol=0;
    for (int i=0;i<arr.Length; i++)
    {
        if ((arr[i]>=10)&&(arr[i]<=99)) kol++;
    }
    return kol;
}
Console.Clear();
int[] array = GetArray(123, -100, 150);
Console.WriteLine(String.Join(" ", array));
Console.Write("Количество элементов из отрезка [10,99] ->");
Console.WriteLine(Kol_Array(array));


//
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
//

int[] Create_New_Array(int[] arr)
{
    int size=0;
    if (arr.Length%2==1) size=arr.Length/2+1;
    else size=arr.Length/2;
    
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        if ((arr.Length%2==1)&&(i==size-1)) res[i]=arr[i];
        else res[i] = arr[i]*arr[arr.Length-i-1];
    }
    return res;
}

Console.WriteLine("-------------");


int[] array2= Create_New_Array(array);
Console.WriteLine(String.Join(" ", array2));


