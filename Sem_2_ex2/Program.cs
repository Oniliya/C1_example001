int Max(int ar1, int ar2,  int ar3)
{
 int result =ar1;
 if (ar2>result) result = ar2;
 if (ar3>result) result = ar3;
 return result;
}

int [] array ={1,342,3345,4,345,635,7,8354,93333};
array[0]=15;
Console.WriteLine(array[0]);

int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);
Console.WriteLine(max);