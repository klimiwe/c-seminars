/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


int number =  new Random (). Next (1, 10000);
Console.WriteLine ("Компьютер сгенерировал случайное число: " + number);
int thirdFigure;

if (number>99)
{
     while (number>=999)
     {
        
        number = number/10;
     }
     Console.WriteLine("Третья цифра в числе "  +" :" + number%10);
}
else 
{
    Console.WriteLine ("В числе нет третьей цифры");
}

