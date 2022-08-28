// Заполнить массив и развернуть его

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
void ReversArray (int [] inArray)
{
    int [] result = new int [inArray.Length];
    for (int i =0; i<inArray.Length; i++)
    {
        result [i] =inArray [inArray.Length-1-i];
        Console.Write ($"{result[i]} ");
    }
}

int [] array = GetArray(10,0,10);
PrintArray (array);
Console.WriteLine();
ReversArray(array);