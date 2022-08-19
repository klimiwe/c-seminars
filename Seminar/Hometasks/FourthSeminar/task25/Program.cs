/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
int degreeOfNumber (int a, int b)
{
    int result = a;
if (b>0)
{
    for (int i=2; i<=b; i++)
    {
        result = result * a;
        Console.WriteLine(a+" в степени " + i +" = " + result);
    }
}
else 
{
    Console.WriteLine("Вы ввели недопустимое значение переменной b");
}
return result;
}
int a,b;
Console.WriteLine("Введите число a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
b = int.Parse(Console.ReadLine());
degreeOfNumber(a,b);