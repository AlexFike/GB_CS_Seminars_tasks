// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Clear();

Console.Write("input number: ");
int number = int.Parse(Console.ReadLine()!);

if (number / 1000 == 0 && number / 100 > 0)
{
    Console.Write($"Third digit of number = {number % 10}");
}
else Console.Write("Not valid namber");

