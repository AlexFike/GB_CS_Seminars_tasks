// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("input number N: ");
int number = int.Parse(Console.ReadLine()!);


if (number > 1)
{
    Console.Write("All even numbers up to N --> ");
    
    for (int i = 2; i < number + 1; i += 2) Console.Write($"{i} ");
}
else Console.Write("No a even number value");