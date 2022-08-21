/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int[] array = GetArray(8, 0, 9);
PrintArray(array);
Console.WriteLine();
int length = array.Length;
int sumOfNumber = 0;
for (int i = 0; i < length; i++)
{
       if (i%2!=0)
       {
       sumOfNumber +=array[i];   
        }
}

    Console.WriteLine ("Сумма чисел с нечетным индексом в массиве = " + sumOfNumber);