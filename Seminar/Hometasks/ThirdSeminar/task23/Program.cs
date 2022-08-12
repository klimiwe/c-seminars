/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
int n;
Console.WriteLine("Введите количество чисел");
n = Convert.ToInt32(Console.ReadLine());
int i;
int cube;
for (i=1;i<=n; i++)
{
    cube = i*i*i;
    Console.WriteLine(cube);
}

