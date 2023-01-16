﻿//
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
int[] array = GetArray(123, -100, 100);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(Kol_Array(array));


//
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
//


// int[] array3 = GetArray(5, -10, 10);
// Console.WriteLine(String.Join(" ", array3));

// int n=GetNumberFromUser($"Введите число ", "Ошибка ввода!");

// if (Check(n, array3)) Console.WriteLine("да");
// else Console.WriteLine("нет");

