/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetDoubleArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();
AverageSumOfNumbersInColumns(array);


int[,] GetDoubleArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}
void AverageSumOfNumbersInColumns(int[,] array)

{

    double averageSum = 0;
     for (int  i = 0; i <array.GetLength(1); i++)
    {
        averageSum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
           averageSum = (averageSum + array [j,i]);
            //Console.WriteLine(averageSum);
        }
        
             Console.Write($"{averageSum = Math.Round((averageSum / array.GetLength(0)),2)} ");
        
    }
}