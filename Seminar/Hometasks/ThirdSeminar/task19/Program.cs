/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
string polindrom(int number)
{
    int fifthFigure = number%10;
    int fourthFigure = (number/10)%10;
    int secondFigure = (number/1000)%10;
    int firstFigure = number/10000;
    string result;
    if (firstFigure==fifthFigure && secondFigure==fourthFigure)
    {
    result = "Число является палиндромом";
    }
    else 
    {
        result = "Число не является палиндромом";
    }
    return result;
}

int number;
Console.WriteLine("Введите пятизначное число: ");
number = Convert.ToInt32(Console.ReadLine());
string result = polindrom (number);

if (number>9999 && number<100000)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
