// Программа для разворота массива

int[] array = { 2,3,5,6 };
int N = array.Length;
for (int i=0; i<N/2; i++)
{
int temp = array[i];
array[i]=array[N - i - 1];
array[N - i - 1]=temp;
}
for (int i = 0; i<N; i++)
{
Console.WriteLine(array[i]);
}
