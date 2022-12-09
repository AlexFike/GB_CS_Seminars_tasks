// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Input number: ");
int numberX = int.Parse(Console.ReadLine()!);

int ProductOfNumber(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

int RecProductOfNumber(int number)
{
    if (number == 1) return 1;
    else return number * RecProductOfNumber(number - 1);
}

Console.WriteLine($"The product of number = {ProductOfNumber(numberX)}");
Console.WriteLine($"The product of number(recursion) = {RecProductOfNumber(numberX)}");