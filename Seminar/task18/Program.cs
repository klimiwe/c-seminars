/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
string coordinats (int querter)
{
    string result;
if (querter==1)
{
result = "X>0 y>0";
}
else if (querter==2)
{
result = "X<0 y>0";
}
else if (querter==3)
{
result = "X<0 y<0";
}
else if (querter==4)
{
result = "X>0 y<0";
}
else 
{
    result = "Вы ввели не корректное значение четверти.";
}
return result;
}


int querter;
Console.WriteLine("Введите четверть в которой располагается точка. ");
querter = Convert.ToInt32(Console.ReadLine());
string result = coordinats(querter);

Console.WriteLine("Возможные значения: " + result);
