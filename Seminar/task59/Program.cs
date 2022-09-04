/*Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.*/

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

int min = 0, max = 99;
int[,] array = GetDoubleArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine();

int rowMinNumber = RowMinNumberInArray(array);
int columnMinNumber = ColumnMinNumberInArray(array);

int[,] resultArray = GetArrayWithoutMinRowAndColumn(array, rowMinNumber, columnMinNumber);
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

int RowMinNumberInArray(int[,] array)
{
    int minNumber = array[0, 0], rowMinNumber = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                rowMinNumber = i;

            }

        }

    }
    Console.WriteLine($"row min = {rowMinNumber}");
    return rowMinNumber;

}
int ColumnMinNumberInArray(int[,] array)
{
    int minNumber = array[0, 0], columnMinNumber = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                columnMinNumber = j;
            }

        }
    }
    Console.WriteLine($"column min = {columnMinNumber}");
    return columnMinNumber;

}

int[,] GetArrayWithoutMinRowAndColumn(int[,] array, int rowMinNumber, int columnMinNumber)
{
    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == rowMinNumber) continue;
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (j == columnMinNumber) continue;
            
                resultArray[k, l] = array[i, j];
                l++;
        }
            
            k++;
            l=0;

        }
        }
      return resultArray;

    }
    


