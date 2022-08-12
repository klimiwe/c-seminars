/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/


double distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya) + (zb-za)*(zb-za)));
    distance = Math.Round(distance,2);
    return distance;
}


int xa,ya,za,xb,yb,zb;
Console.WriteLine("ВВедите координаты первой точки сначала X, затем Y, затем Z: ");
xa = Convert.ToInt32(Console.ReadLine());
ya = Convert.ToInt32(Console.ReadLine());
za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите координаты второго точки сначала X, затем Y, затем Z: ");
xb = Convert.ToInt32(Console.ReadLine());
yb = Convert.ToInt32(Console.ReadLine());
zb = Convert.ToInt32(Console.ReadLine());
double result = distance(xa,ya,za,xb,yb,zb);
Console.WriteLine("Расстояние между заданными точками = "+ result);