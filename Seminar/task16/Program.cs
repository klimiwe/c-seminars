/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

bool isSquare (int firstNumber, int secondNumber)
{
bool result;
if (firstNumber*firstNumber==secondNumber)
{ 
    result = true;
   
}
else if (firstNumber==secondNumber*secondNumber)
{
    result = true;
}
else 
{
    result = false;
}
return  result;

}

int firstNumber;
Console.WriteLine("Введите число 1: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

int secondNumber;
Console.WriteLine("Введите число 2: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

bool check = isSquare (firstNumber, secondNumber);

if (check == true)
{
    Console.WriteLine("Одно из чисел является квадратом другого.");
}
else
{
Console.WriteLine("Ни дно из чисел не является квадратом другого.");
}