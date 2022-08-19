/* Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int countOfFigure (int number)
{
    int count=0;
while (number!=0)
{
    number = number/10;
    count ++;
}
return count;
}

int number;
Console.WriteLine("Введите число");
number  = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в введенном числе = {countOfFigure(number)}");
