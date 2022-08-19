int multOfNumber (int a)
{
    int result = 1 ;
    for (int i=1 ; i<=a; i++)
    {
result = result*i;
   }
   return result;
}

int a;
Console.WriteLine("Введите количество чисел");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Произведение чиел от 1 до а = {multOfNumber(a)}");

