//----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
//количество итераций и время последовательность фибонначи
decimal fRec=0;
decimal fIte=0;

decimal FibonnacciRecursion(int n)
{
    fRec++;
    return n ==0 || n==1 ? 1 :FibonnacciRecursion(n-1)+FibonnacciRecursion(n-2);
}

decimal FibonnacciIteration(int n)
{
    fIte++;
    decimal result =1;
    decimal f0=1;
    decimal f1=1;
    for (int i=2; i <= n ; i++)
    {
        result= f0+f1;
        f0=f1;
        f1= result;
        fIte++;
    }
    return result;
}

//# 1 2 3 4 5 6
//V 1 1 2 3 5 8

Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n=10; n<40; n++)
{
    Console.WriteLine($"FibonnacciIteration({n}) = {FibonnacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte=0;
}
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n=10; n<40; n++)
{
    Console.WriteLine($"FibonnacciRecursion({n}) = {FibonnacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec=0;
}
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);





// //----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
// //обход дерева
// string emp=String.Empty;
// string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"} ;
// //                  0    1    2     3    4    5    6    6    8    9    10   11
// void InOrderTraversal(int pos=1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2*pos;
//         int right = 2*pos+1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }

// InOrderTraversal();



// //----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
// //ханойская башня
// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();



//----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
// char[] s= {'а','и','с','в'};

// int count = s.Length;
// int n=1;
// // for (int i=0; i<count; i++)
// // {
// //     Console.WriteLine($"{n++,-5}{s[i]}");
// // }

// for (int i=0; i<count; i++)
// {
//     for (int j=0; j<count; j++)
//     {
//         for (int k=0; k<count; k++)
//         {
//             for (int l=0; l<count; l++)
//             {
//                 for (int m=0; m<count; m++)
//                 {
//                     Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                 }
//             }
//         }
//     }
// }

// int n=1;
// void FindWords (string alphabet, char[] word, int length =0)
// {
//     if (length==word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word) }"); return;
//     }
//     for (int i=0; i<alphabet.Length; i++)
//     {
//         word[length]= alphabet[i];
//         FindWords(alphabet, word, length+1);
//     }
// }
// FindWords("аисв", new char[5]);

//----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача


// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i=a; i<=b; i++)
//     {
//         result+= $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a<=b) return $"{a} "+ NumbersRec(a+1,b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1,10));
// Console.WriteLine(NumbersRec(1,10));

//----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i=a; i>=b; i--)
//     {
//         result+= $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a<=b) return NumbersRec(a+1,b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(10,1));
// Console.WriteLine(NumbersRec(1,10));

//----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
// int SumFor (int n)
// {
//     int result=0;
//     for (int i=1; i<=n; i++) result +=i;
//     return result;
// }
// int SumRec(int n)
// {
//     if (n==0) return 0;
//     else return n+SumRec(n-1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));


//----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
// int FartorialFor (int n)
// {
//     int result=1;
//     for (int i=1; i<=n; i++) result *=i;
//     return result;
// }
// int FactorialRec(int n)
// {
//     if (n==0) return 1;
//     else return n*FactorialRec(n-1);
// }

// Console.WriteLine(FartorialFor(10));
// Console.WriteLine(FactorialRec(10));

//----------------задача----------------задача----------------задача----------------задача----------------задача----------------задача
// int PowerlFor (int a, int n)
// {
//     int result=1;
//     for (int i=1; i<=n; i++) result *=a;
//     return result;
// }
// int PowerRec(int a, int n)
// {
//     if (n==0) return 1;
//     else return PowerlFor(a, n-1)*a;
//     //return n == 0 ? 1 : PowerlFor(a, n-1)*a;
// }
// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n%2 ==0) return PowerRecMath(a*a, n/2);
//     else return PowerRecMath(a, n-1)*a;
// }

// Console.WriteLine(PowerlFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));
