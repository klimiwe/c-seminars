int biggestFigureInNumber(int number)
{
    int firstNumber, secondNumber;
    secondNumber = number % 10;
    firstNumber = (number - secondNumber) / 10;
    int result;
    if (firstNumber > secondNumber)
    {
        result = firstNumber;
    }
    else
    {
        result = secondNumber;
    }
    return result;
}

int number = new Random().Next(10, 99 + 1);
Console.WriteLine("Компьютер сгенирировал случайное число в диапазоне от 10 до 99. Это: " + number);
int biggestFigure = biggestFigureInNumber (number);
Console.WriteLine("Большая цифра в этом числе: " + biggestFigure);

