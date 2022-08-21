/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
double [] GetArray(int size, int minValue, int maxValue)
{
    double [] res = new double [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;

}
void PrintArray(double [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
double GetMaxMin (double [] arr)
{
    double min = arr[0];
    double max = arr[0];
    double result=0;
    for(int i=1;i<arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min=arr[i];
        }
        if (arr[i]>max)
        {
            max=arr[i];
        }
    }
    result = max-min;
    return result;
}
double [] array = GetArray(8, 0, 9);
PrintArray(array);
Console.WriteLine ($"Разница между максимальным и минимальным значением в массиве = {GetMaxMin(array)}");
