/*  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
double distance(int xa, int ya, int xb, int yb)
{
    double distance = Math.Sqrt(((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya)));
    return distance;
}


int xa,ya,xb,yb;
Console.WriteLine("ВВедите координаты первой точки сначала X, затем Y: ");
xa = Convert.ToInt32(Console.ReadLine());
ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите координаты второго точки сначала X, затем Y: ");
xb = Convert.ToInt32(Console.ReadLine());
yb = Convert.ToInt32(Console.ReadLine());
double result = distance(xa,ya,xb,yb);
Console.WriteLine("Расстояние между заданными точками = "+ result);