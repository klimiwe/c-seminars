int RandomThreeDigit (int minNumber, int maxNumber)
{
int result = new Random (). Next (minNumber, maxNumber+1);
return result;
}

int thirdDigitWithoutSecond (int number)
{
int firstDigit = number/100;
int thirdNumber = number%10;
int finalNumber = (firstDigit*10) + thirdNumber;
return finalNumber;

}


int thirdDigitNumber = RandomThreeDigit (99,999);
Console.WriteLine (thirdDigitNumber);
int finalNumber = thirdDigitWithoutSecond (thirdDigitNumber);
Console.WriteLine (finalNumber);
