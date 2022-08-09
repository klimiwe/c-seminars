/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

int remainderDivision(int firstNumber, int secondNumber)
{
    int result = secondNumber % firstNumber;
    return result;
}

int firstNumber, secondNumber;
Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = remainderDivision(firstNumber, secondNumber);
Console.WriteLine("Остаток от деления = " + remainder);

if (remainder == 0)
{
    Console.WriteLine("Второе число кратно первому.");
}
else
{
    Console.WriteLine("Второе число не кратно первому. Остаток от деление второго числа на первое = " + remainder);
}