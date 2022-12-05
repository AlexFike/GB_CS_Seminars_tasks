// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да 

Console.Clear();

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"The number {number} is a multiple of 7 and 23");
}
else
{
    Console.WriteLine($"The number {number} is not a multiple of 7 and 23");
}