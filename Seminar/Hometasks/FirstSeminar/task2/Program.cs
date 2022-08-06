/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
int number, remainder;
Console.Write("Введите число: ");

number = Convert.ToInt32(Console.ReadLine());

remainder = number % 2;

if (remainder == 0)
{ Console.WriteLine("Число " + number + " является четным."); }

else
{ Console.WriteLine("Число " + number + " не является четным."); }
