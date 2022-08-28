/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

Console.Clear();
Console.WriteLine ("Введите количество строк ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());
int [,] array = GetDoubleArray(m,n);

PrintArray(GetDoubleArray(m,n));
Console.WriteLine();
Console.WriteLine("Сумма элементов находящихся на главной диагонали = " + SumOfNumbersInIndex(array));

int [,] GetDoubleArray(int m, int n)
{
    int[,] result = new int[m,n];
   
    for (int i =0; i<m; i++)
    {
        for (int j =0; j<n; j++)
        {
            result [i,j] = i+j;
        }
    }
    return result;
}
void PrintArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
          Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
int SumOfNumbersInIndex (int [,] array)
{
    int sum=0;

    for (int i =0; i<array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1); j++)
        {
            if (i==j)
            {
                sum = sum +array[i,j];
            }
        }
    }
    return sum;
}
