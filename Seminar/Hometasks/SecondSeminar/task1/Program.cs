/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98*/
int numberWithoutSecondFigureOfNumber (int thirdDigitNumber)
{
    int firstFigure = thirdDigitNumber/100;
    int thirtFigure = thirdDigitNumber%10;
    int result = firstFigure*10+thirtFigure;
    return result;
}

int thirdDigitNumber =  new Random (). Next (100, 999+1);
Console.WriteLine ("Компьютер сгенерировал случайное трехзначное число: " + thirdDigitNumber);
int result = numberWithoutSecondFigureOfNumber (thirdDigitNumber);
Console.WriteLine ("Не понятно зачем компьютер выкинул вторую цифру из числа. И получилось: " + result);
