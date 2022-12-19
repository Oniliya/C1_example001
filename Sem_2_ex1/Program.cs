int Max(int ar1, int ar2,  int ar3)
{
 int result =ar1;
 if (ar2>result) result = ar2;
 if (ar3>result) result = ar3;
 return result;
}

int a1 =12;
int b1 =12;
int c1 =12;

int a2 =12;
int b2 =312;
int c2 =12;

int c3 =12;
int b3 =12;
int a3 =12;




//int max1=Max(a1, b1, c1);
//int max2=Max(a2, b2, c2);
//int max3=Max(a3, b3, c3);
int max12= Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));



Console.WriteLine(max12);