/* заполнить массив из 12 элементов [-9,9] найти сумму отрицательных и положительных элементов*/

int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i=0; i<size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue+1);
   }
    return res;

}
void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i=0; i<length; i++)
    {
        Console.WriteLine (arr [i]);
    }
}

int [] array = GetArray (12, -9, 9);
PrintArray (array);
int positiveSum = 0;
int negativeSum = 0;

foreach (int i in array)
{
    if (i>0)
    positiveSum +=i;
    else
    negativeSum +=i;
}
Console.WriteLine ("Sum of positive element = " + positiveSum);
Console.WriteLine ("Sum of negative element = " + negativeSum);
