// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Вводим массив через консоль

Console.WriteLine("Введите восемь элементов массива через пробел");
string N = Console.ReadLine();
int i = 0;

string[] array = N.Split(" ");
if (array.Length != 8)
{
    Console.WriteLine("Данные введены неверно!");
}
else
{

    for (i = 0; i < 8; i++)
    {
        if (i != 7)
        {
            Console.Write(array[i] + ", ");
        }

        else
        {
            Console.Write(array[i]);
        }

    }
}