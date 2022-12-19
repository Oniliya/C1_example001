int[] array={1,342,3,8 ,8 ,8 ,354,4,635,7,8};
int n = array.Length;
int find = 8;
int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
       Console.WriteLine(index) ;
       break;
    }
    index=index+1; //index++;
}