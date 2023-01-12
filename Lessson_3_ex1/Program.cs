// void Method1()
// {
//     Console.WriteLine("Автор  ");

// }
// Method1();


// void Method2(string msg)
// {
//     Console.WriteLine(msg);

// }
// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i< count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
  

// }
// Method2(msg: "Text message 1");
// Method21("Text message",4);
// Method21(msg: "Text message", count: 4);
// Method21(count: 4, msg: "New text message" );


// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// string Method4(int count, string t2)
// {
//     int i=0;
//     string result=String.Empty;
//     while (i<count)
//     {
//         result=result+t2;
//         i++;
//     }
//     return result;
// }

// string t1 = Method4(3, "Hello");
// Console.WriteLine(t1);


// string Method4(int count, string t2)
// {
//     string result=String.Empty;
//     for (int i=0; i<count; i++)
//     {
//         result=result+t2;
//     }
//     return result;
// }

// string t1 = Method4(5, "Hello");
// Console.WriteLine(t1);

// for (int i=1; i<=10; i++)
// {
//    for (int j=1; j<=10; j++)
//    {
//         Console.WriteLine($"{i}*{j}={i*j}");
//    }
//    Console.WriteLine();
// }

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю? ССС";
// //string s = "qwerty"
// //            012345 
// // s[3] r

// string Replace(string text, char old_value, char new_value)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i =0; i<length; i++)
//     {
//         if (text[i] == old_value) result= result + $"{new_value}";
//         else result = result + $"{text[i]}";

//     }
//     return result;
// }

// string newText = Replace(text,' ','|');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText,'к','К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText,'С','с');
// Console.WriteLine(newText);


int[] arr = {1,6,8,7,2,4,3,9,5,8,4,5};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
       Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
   for (int i=0; i<array.Length-1; i++)
    {
       int minPosition = i;
       for (int j=i+1; j<array.Length; j++)
       {
        if (array[j]< array[minPosition]) minPosition=j;
       }
       int temporary = array[i];
       array[i]=array[minPosition];
       array[minPosition]= temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

