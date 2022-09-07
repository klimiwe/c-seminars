//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12


int sum (int number)
{
    if (number==0) return 0;
    else return number%10 + sum(number/10);
}

Console.WriteLine (sum (343213));