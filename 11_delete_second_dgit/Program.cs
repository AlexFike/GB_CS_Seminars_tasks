
int DelTwoDigitNum(int number)
{

    int number1 = number / 100,
        number3 = number%10;

    int result = number1 * 10 + number3;

    return result;  
}

int numberTest = new Random().Next(100, 1000);
Console.WriteLine($"Delet two digit for {numberTest}. Result = {DelTwoDigitNum(numberTest)}");
