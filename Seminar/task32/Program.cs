/*Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/


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
        Console.Write (arr [i] + " ");
    }
}

int [] array = GetArray (12, -9, 9);
PrintArray (array);
Console.WriteLine ();
int length = array.Length; 
for(int i=0; i<length; i++)
{
    array[i] = array[i]*(-1);
    Console.Write(array[i] + " ");  
}
