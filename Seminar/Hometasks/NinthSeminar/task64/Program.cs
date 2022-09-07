/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.

M = 1; N = 5. -> ""5, 4, 3, 2, 1""

M = 4; N = 8. -> ""8, 7, 6, 5, 4""*/

Console.WriteLine ("Введите меньшее число.");
int m = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите большее число.");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(NumberFromNToM(m,n));

string NumberFromNToM(int m, int n)
{
    if (n>m) return $"{n} " + NumberFromNToM(m,n-1);
    else return $"{n} ";
}