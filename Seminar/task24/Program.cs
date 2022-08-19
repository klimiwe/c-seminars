/* Напишите программу, которая 
принимает на вход число (А) и выдаёт сумму чисел 
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int sumOfNumber (int a)
{
    int result = 0 ;
    for (int i=1 ; i<=a; i++)
    {
result += i;
   }
   return result;
}

int a;
Console.WriteLine("Введите количество чисел");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Сумма чиел от 1 до а = {sumOfNumber(a)}");

