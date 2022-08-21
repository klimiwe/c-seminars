/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

int[] array = GetArray(8, 100,999);
PrintArray(array);
Console.WriteLine();
int length = array.Length;
int countEvenNumber = 0;
for (int i = 0; i < length; i++)
{
       if (array[i]%2==0)
       {
        countEvenNumber++;
        }
}

    Console.WriteLine ("Колличество четных чисел в массиве = " + countEvenNumber);
