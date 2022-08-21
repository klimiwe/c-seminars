/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

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
int[] NewArray(int[] array)
{
    int[] newArray;
    int length = array.Length;
    int j = 0;
    if (length / 2 > 0)
    {
        newArray = new int[length / 2 + 1];
        for (j = 0; j < length / 2; j++)
        {
            newArray[j] = array[j] * array[length - 1 - j];
        }
        newArray[length / 2] = array[length / 2];

    }
    else
    {
        newArray = new int[length / 2];
        for (j = 0; j < length / 2; j++)
        {
            newArray[j] = array[j] * array[length - 1 - j];
        }
    }
    return newArray;



}
int[] array = GetArray(7, 0, 9);
PrintArray(array);
int[] newArray = NewArray(array);
Console.WriteLine();
PrintArray(newArray);


