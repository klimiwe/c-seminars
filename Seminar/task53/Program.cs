//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetDoubleArray(m, n);
PrintArray(array);
Console.WriteLine();
int[,] changedArray = ChangeFirsAndLastRowOfArray(array);
PrintArray(changedArray);

int[,] GetDoubleArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
int[,] ChangeFirsAndLastRowOfArray(int[,] array)
{
    int[,] changedArray = new int[m, n];
    changedArray = array;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        changedArray[0, j] = array[array.GetLength(0) - 1, j];
        changedArray[array.GetLength(0) - 1, j] = temp;
    }
    return changedArray;
}