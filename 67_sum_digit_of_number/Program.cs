// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigitOfNumber(int n)
{
    return (n > 9) ? n % 10 + (SumDigitOfNumber(n / 10)) : n;
}

Console.WriteLine(SumDigitOfNumber(453));
Console.WriteLine(SumDigitOfNumber(45));

