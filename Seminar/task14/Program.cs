/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

int division7 (int number)
{
    int div7 = number%7;
    return div7;
}
int division23 (int number)
{
    int div23 = number%23;
    return div23;

}

int number;
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
int remainder7 = division7 (number);
int remainder23 = division23 (number);

if (remainder7 == 0 & remainder23 == 0)
{
    Console.WriteLine("Введенное число  делится без остатка на 7 и 23.");
}

else
{
Console.WriteLine("Введенное число  не делится без остатка на 7 и 23.");
}