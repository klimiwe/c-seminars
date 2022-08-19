/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int number;
Console.WriteLine("Введите любое число");
number = int.Parse(Console.ReadLine());
if (number>0)
{
    number =number;
}
else 
{
    number = number*(-1);
}
int sumOfFigure = 0;
while (number>0)
{
sumOfFigure=sumOfFigure+number%10;
number=number/10;
}
Console.WriteLine ("Сумма цифр в веденном числе = " + sumOfFigure);
