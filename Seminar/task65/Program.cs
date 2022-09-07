/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/


Console.WriteLine("Введите первое число.");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число.");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Number(m, n));


string Number (int m, int n)
{
    if (m<=n)
    {
        return $"{m} " + Number(m+1, n);
    }
    else
    {
        return string.Empty;
    }
}