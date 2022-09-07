//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.WriteLine("Введите количество чисел.");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Number(1, n));

string Number(int first, int last)
{
    if (first <= last)
    {
        return $"{first} " + Number(first + 1, last) ;
    }
    else
    {
        return string.Empty;
    }
}