/* 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int size;
Console.WriteLine("Укажите колличество чисел, которое вы хотите ввести.");
size = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetUserArray (size);
PositiveNumbers(userArray);


int [] GetUserArray (int size)
{
Console.WriteLine("Вводите числа по одному.");
int [] userNumbers = new int [size];
for (int i=0; i<size; i++)
{
    userNumbers [i] = Convert.ToInt32 (Console.ReadLine());
}
return userNumbers;
}

void PositiveNumbers (int[] userArray)
{
    int i=0, count=0;

    while (i<userArray.Length)
    {
        if (userArray[i]>0)
        {
count++;
        }
        i++;
}
Console.WriteLine ("Вы ввели " +count+ " числа больше 0");
}
