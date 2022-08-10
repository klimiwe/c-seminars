/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
string nameOfTheDay(int numberOfTheDay)
{
    string result;
    if (numberOfTheDay == 1)
    {
        result = "понедельник";
    }
else if (numberOfTheDay == 2)
    {
        result = "вторник";
    }
    else if (numberOfTheDay == 3)
    {
        result = "среда";
    }
    else if (numberOfTheDay == 4)
    {
        result = "четверг";
    }
    else if (numberOfTheDay == 5)
    {
        result = "пятница";
    }
    else if (numberOfTheDay == 6)
    {
        result = "суббота";
    }
    else 
    {
        result = "воскресенье";
    }
    return result;
    
}

Console.WriteLine ("Введите номер дня недели.");
int numberOfTheDay = Convert.ToInt32(Console.ReadLine());
string name;
if (numberOfTheDay > 0 & numberOfTheDay < 8)
{
    name = nameOfTheDay(numberOfTheDay);
    Console.WriteLine("Сегодня " + name);
}
else 
{
    Console.WriteLine("Такого дня не существует");
}
