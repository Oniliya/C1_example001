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

// int Calc(int x,int x1)
// {
//     int mult=1;
//     for (int i=1;i<=x1;i++)
//     {
//         mult=mult*x;
//     }
//     return mult;
// }

// int a = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
// int b = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");

// Console.Write($"{a},{b}->{Calc(a,b)}");





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


