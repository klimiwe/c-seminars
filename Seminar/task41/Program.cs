/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

int number;
Console.WriteLine("Введите длину стороны a.");
number = Convert.ToInt32(Console.ReadLine());

int n=number;
int remains=0;
while(number>0)
{
    remains=number%2;
    Console.Write (remains);
    number =number/2;
}