/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


Console.WriteLine("Введите количество строк в первой матрице");
int firstRows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в первой матрице");
int firstColumns = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк во второй матрице");
int secondRows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов во второй матрице");
int secondColumns = int.Parse(Console.ReadLine());

if (firstRows!=secondColumns && firstColumns!=secondRows) { Console.WriteLine("Такие матрицы нельзя перемножить.");}
else
{
int min = 0, max =9;
int[,] firstMatrix = GetDoubleArray(firstRows, firstColumns, min, max);
PrintArray(firstMatrix);
int[,] secondMatrix = GetDoubleArray(secondRows, secondColumns, min, max);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine($"Произведение матриц");
PrintArray (MatrixProduct(firstMatrix,secondMatrix));
}

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
int [,] MatrixProduct (int[,] firstMatrix, int [,] secondMatrix)
{
    int [,] matrixProduct = new int [firstMatrix.GetLength(0),secondMatrix.GetLength(1)];
    for (int i = 0; i < matrixProduct.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrixProduct.GetLength(0); j++)
        {
            for(int k=0; k<firstMatrix.GetLength(0); k++)
            {
            matrixProduct [i,j] += firstMatrix[i,k]*secondMatrix[k,j];
            }
        }
              
    }
   
return matrixProduct;
}



