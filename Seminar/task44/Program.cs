Console.Clear();
Console.WriteLine ("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
int [,] array = GetDoubleArray(rows,columns,0,20);
PrintArray (array);
Console.WriteLine();
PrintArray(ChangeArray(array));


int [,] GetDoubleArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n; j++)
        {
            result [i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

int [,] ChangeArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            if (i%2==0 && j%2==0)
            {
                array[i,j]*=array[i,j];
            }
        }
    }
    return array;
}
void PrintArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
          Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
    
}