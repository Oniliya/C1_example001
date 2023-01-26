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
