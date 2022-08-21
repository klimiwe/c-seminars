/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

int[] array = GetArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int length = array.Length;
int number = 4;
int countNumber = 0;
for (int i = 0; i < length; i++)
{
       if (array[i] == number)
       {
        countNumber ++;   
        }
}
if (countNumber>0)
{
    Console.WriteLine ("YES");
}
else 
{
    Console.WriteLine ("NO");
}
