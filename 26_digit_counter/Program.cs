// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DigitCounter(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.Write("Input number: ");
int numberX = int.Parse(Console.ReadLine()!);

int numberXM = Convert.ToInt32(Math.Ceiling(Math.Log10(numberX)));

Console.WriteLine($"count of digits in a number = {DigitCounter(numberX)}");
Console.WriteLine($"count of digits in a number = {numberXM}");