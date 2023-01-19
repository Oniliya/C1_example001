// //
// //Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// //
// int GetNumberFromUser(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//         if (isCorrect)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }

// bool CheckTriangle(int x, int y, int z)
// {
//     if ((x+y>z)&&(x+z>y)&&(y+z>x)) return true;
//     else return false;

// }

// int a=GetNumberFromUser($"Введите число ", "Ошибка ввода!");
// int b=GetNumberFromUser($"Введите число ", "Ошибка ввода!");
// int c=GetNumberFromUser($"Введите число ", "Ошибка ввода!");

// if (CheckTriangle(a,b,c)) Console.WriteLine("Yes");
// else Console.WriteLine("No");


















//
//
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//
// void PrintString(string str)
// {
//     for (int i=0; i<str.Length; i++)
//     {
//         Console.Write(str[str.Length-i-1]);

    
//     }
// }

// int GetNumberFromUser(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//         if (isCorrect)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }

// string DigitConvert(int x)
// {
//     string s="";
//     while(x>0)
//     {
//         if (x%2==1) s=s.Insert(0,"1"); //s=s+"1";
//         else  s=s.Insert(0,"0"); //s=s+"0";
//         x=x/2;
//     }
//     return s;
// }

// int n=GetNumberFromUser($"Введите число ", "Ошибка ввода!");
// string row=DigitConvert(n);
// //PrintString(row);
// Console.WriteLine(row);








// //
// //Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// //Первые два числа Фибоначчи: 0 и 1.
// //
// int GetNumberFromUser(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//         if (isCorrect)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }

// int[] CreateArray(int size)
// {
//     int[] res = new int[size];
//     res[0]=0;
//     res[1]=1;
//     for (int i = 2; i < size; i++)
//     {
//         res[i] = res[i-2]+res[i-1];
//     }
//     return res;
// }

// void PrintArray(int[] arr)
// {
//     for (int i=0; i<arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// int n=GetNumberFromUser($"Введите число ", "Ошибка ввода!");
// int[] Fib_Array = CreateArray(n);
// PrintArray(Fib_Array);



//
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
//
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size)
{
    int[] res = new int[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1,100);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] arr1)
{
    int[] arr2= new int[arr1.Length];
    for (int i=0; i<arr1.Length; i++)
    {
        arr2[i]=arr1[i];
    }
    return arr2;
}

int n=GetNumberFromUser($"Введите число ", "Ошибка ввода!");
int[] mas1=GetArray(n);
int[] mas2=CopyArray(mas1);
PrintArray(mas1);
PrintArray(mas2);
