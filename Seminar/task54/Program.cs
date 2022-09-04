/*Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

int min = 0, max =99;
int[,] array = GetDoubleArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine();
CountOfNumbersInArray (array, min, max);


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
void CountOfNumbersInArray(int[,] array, int min, int max)
{
    int number = 0, count = 0;

    while (number < max)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == number) {count++;}
            }
        }
        if (count>0) {Console.WriteLine($"{number} встречается {count} раз.");}

        number++;
        count = 0;
    }

}