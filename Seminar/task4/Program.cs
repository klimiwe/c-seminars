/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/
int number;

Console.WriteLine("Введите трехзначное число. ");
number = Convert.ToInt32(Console.ReadLine());
if (number<100 || number>999) {
    Console.WriteLine("Вы ввели не трехзначное число.");
}
else {
    Console.WriteLine("Последняя цифра введенного числа = " + (number%10));
}