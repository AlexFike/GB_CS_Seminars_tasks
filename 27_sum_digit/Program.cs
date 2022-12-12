// Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SumDigit(number / 10);
}

Console.WriteLine(SumDigit(5555));