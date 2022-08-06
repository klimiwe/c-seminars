/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int firstNumber, secondNumber, thirdNumber, max, min;
Console.Write("Введите первое число: ");

firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber>secondNumber)
{max = firstNumber;}
else 
{max =secondNumber;}
if (thirdNumber>max)
{max=thirdNumber;}
Console.WriteLine("Максимальное число: " + max);