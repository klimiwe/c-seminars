/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Clear();
int rows = 5, columns = 5;
int[,] array = GetDoubleArray(rows, columns, -9, 9);

Console.WriteLine("Введите номер строкт искомого элемента ");
int userRows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер столбца искомого элемента ");
int userColumns = int.Parse(Console.ReadLine());


PrintArray(array);
if (userRows<0 | userRows>rows | userColumns<0 | userColumns>columns)
{
    Console.WriteLine ("Элемента с таким индексом нет в заданном массиве.");
}
else
{
    Console.WriteLine("Элемент с заданными вами индексом имеет следующее значение: " + FindNumberByIndex(userRows, userColumns, array));
}

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
int FindNumberByIndex(int userRows, int userColumns, int[,] array)
{
    int result = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == userRows && j == userColumns)
            {
                result = array[i, j];
            }
        }
    }
    return result;

}
