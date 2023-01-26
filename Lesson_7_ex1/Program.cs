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

Console.WriteLine(PowerlFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));
