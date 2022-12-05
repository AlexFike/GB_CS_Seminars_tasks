// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();

Console.Write("Input first number: ");
int numberF = int.Parse(Console.ReadLine()!);

Console.Write("Input second number: ");
int numberS = int.Parse(Console.ReadLine()!);

if (Math.Abs(numberS) > Math.Abs(numberF))
{                                         
    int swap = numberF;                   
    numberF = numberS;
    numberS = swap;
}

if(numberF%numberS == 0)
{
    Console.WriteLine($"The number {numberF} is a multiple of {numberS}");
}
else
{
    Console.WriteLine($"The number {numberF} is not a multiple of {numberS}");
}