/*Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 56
M = 4; N = 8. -> 18 */

Console.WriteLine ("Введите меньшее число.");
int m = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите большее число.");
int n = int.Parse(Console.ReadLine());

if (m%2 != 0) 
{
    m++;
}



int SumDoubleElements (int m, int n )
{
    if (m<=n) return m + SumDoubleElements(m+2,n);
    else return 0; 
}
Console.WriteLine (SumDoubleElements(m,n));