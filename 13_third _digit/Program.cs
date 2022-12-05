// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int ThirdDigit(int number, int digit)
{
    int div = Convert.ToInt32(Math.Pow(10, digit));

    int result = number;

    while (result / div != 0)
    {
        result = result / 10;
    }
    
    result =  result%10;

    return result;
}

int numberTest = new Random().Next(1, 10000);

if (numberTest / 100 == 0)
{
    Console.WriteLine($"Number {numberTest} does not contain 3 digits");
}
else
{
    Console.WriteLine($"Third digit of number {numberTest} = {ThirdDigit(numberTest, 3)}");
}



char ThirdDigitStr(string number, int digit)
{
    return number[digit -1];
}
string numberTestStr = Convert.ToString(numberTest);

Console.WriteLine($"Third digit of number {numberTest} = {ThirdDigitStr(numberTestStr, 3)}");