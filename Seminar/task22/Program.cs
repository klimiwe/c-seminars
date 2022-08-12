/*
 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/


int n;
Console.WriteLine("Введите количество чисел");
n = Convert.ToInt32(Console.ReadLine());
int i;
int square;
for (i=1;i<=n; i++)
{
    square = i*i;
    Console.WriteLine(square);
}

   
