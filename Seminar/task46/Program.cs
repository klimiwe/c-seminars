/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
PrintArray(GetArray(rows,columns,-9,9));

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] resultArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray [i, j] = new Random().Next(min, max);
        }
    }
    return resultArray;
}

void PrintArray(int [,] array)
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
