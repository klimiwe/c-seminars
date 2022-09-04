/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

int min = 0, max = 99;
int[,] array = GetDoubleArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine();

int[,] resultArray = DescendingOrderInRows(array);
PrintArray(resultArray);

int[,] GetDoubleArray(int rows, int columns, int min, int max)
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().Next(min, max);
        }
    }
    return resultArray;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] DescendingOrderInRows(int[,] originalArray)
{
    for (int i = 0; i < originalArray.GetLength(0); i++)
    {
        for (int j = 0; j < originalArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < originalArray.GetLength(1); k++)

                if (originalArray[i, j] < originalArray[i, k])
                {
                    int temp = originalArray[i, j];
                    originalArray[i, j] = originalArray[i, k];
                    originalArray[i, k] = temp;

                }
        }
    }
return originalArray;

}


