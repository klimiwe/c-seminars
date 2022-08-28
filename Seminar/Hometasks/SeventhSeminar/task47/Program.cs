/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
PrintArray(GetArray(rows,columns,-9,9));

double [,] GetArray(int rows, int columns, int min, int max)
{
    double [,] resultArray = new double [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray [i, j] = new Random().Next(min,max) + new Random().NextDouble();
            resultArray [i, j] = Math.Round(resultArray[i,j], 1);
        }
    }
    return resultArray;
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
