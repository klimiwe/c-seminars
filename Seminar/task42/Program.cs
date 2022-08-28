// Не используя рекурсию вывести  вывести первые N чисел фибоначи

int number;
Console.WriteLine("Введите количество чисел фибоначи");
number = Convert.ToInt32(Console.ReadLine());
int [] array = Fib (number);
PrintArray (array);

int [] Fib(int size)
{
    int[] array = new int [size];
    array[0] = 0;
    array[1]=1;
    for (int i=2; i<size; i++)
    {
        array [i] = array[i-1]+array[i-2];
    }
    return array;
}
void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
