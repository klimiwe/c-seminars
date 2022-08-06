/*Квадрат числа
*/
int userNumber = new int ();
Console.WriteLine("Введите число");
userNumber = Convert.ToInt32(Console.ReadLine());

int result = (userNumber*userNumber);

Console.WriteLine("Степень числа " + userNumber + " = " + result);