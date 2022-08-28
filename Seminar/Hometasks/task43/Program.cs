//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1,b2,k1,k2;
Console.WriteLine("Введите b1");
b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
k2 = Convert.ToInt32(Console.ReadLine());

double x,y;
x=(b1-b2)/(k2-k1);
y = (k2*x)+b2;

Console.WriteLine ("Точка пересечения прямых имеет следующие координаты: x " +x+ ", y " +y);
