
int a,b,c;
Console.WriteLine("Введите длину стороны a.");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны b.");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны c.");
c = Convert.ToInt32(Console.ReadLine());

string result;
result = Result (a,b,c);
Console.WriteLine (result);

string Result (int a, int b,  int c)
{
    string result = string.Empty;
if (a< (b+c) && b<(a+c) && c<(a+b))
{
    result = "Такой треугольник имеет право на жизнь.";
}
else
{
    result = "Отрезки не сложатся в треугольник.";
}
return result;
}
