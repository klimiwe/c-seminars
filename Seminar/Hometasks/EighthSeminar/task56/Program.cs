/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

int min = 0, max = 99;
int[,] array = GetDoubleArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine();

MaxSummRowsInArray(array);

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
void MaxSummRowsInArray(int[,] originalArray)
{
    int[] sumOfNumberinRow = new int[originalArray.GetLength(0)];
    int sumNumberInIRow = 0;
    for (int i = 0; i < originalArray.GetLength(0); i++)
    {
        for (int j = 0; j < originalArray.GetLength(1); j++)
        {
            sumNumberInIRow = sumNumberInIRow + originalArray[i, j];
        }
        sumOfNumberinRow[i] = sumNumberInIRow;

        Console.WriteLine($"Сумма строки {i} = {sumNumberInIRow}");
        sumNumberInIRow = 0;
    }
    int indexMinSum = 0;
    int minSum = sumOfNumberinRow[0];
    for (int k = 0; k < originalArray.GetLength(0); k++)
    {
        if (minSum > sumOfNumberinRow[k])
        {
            minSum = sumOfNumberinRow[k];
            indexMinSum = k + 1;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов  - {indexMinSum}.");

}



