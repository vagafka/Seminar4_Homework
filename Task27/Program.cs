// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
string str = N.ToString();
int sum = 0;
for (int i = 0; i < str.Length; i++)
{
    // sum = sum + Convert.ToInt32(str[i]);
    sum = sum + (int)Char.GetNumericValue(str[i]);
}
Console.WriteLine(sum);



