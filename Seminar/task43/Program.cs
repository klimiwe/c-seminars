// Создать массив и скопировать его с помощью поэлементного копирования

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;

}
void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int [] NewArray (int [] array)
{
    int [] newArray = new int [array.Length];
    for (int i=0; i<array.Length; i++)
    {
        newArray [i] = array[i];
    }
    return newArray;
}

int [] array = GetArray (8, 0,9);
PrintArray (array);
int [] clonedArray = NewArray(array);
Console.WriteLine();
PrintArray (clonedArray);