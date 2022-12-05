// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();

int SecondDigit(int number)
{

    int result = (number%100)/10;

    return result;
}

int rndNumber = new Random().Next(100,1000);

Console.WriteLine($"the second digit of the number = {SecondDigit(rndNumber)}");

