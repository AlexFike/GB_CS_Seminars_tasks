// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Input number A: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Input number B: ");
int b = int.Parse(Console.ReadLine()!);

if(a > b) Console.Write($"Maximum number --> {a}. Minimum number --> {b}");
else Console.Write($"Maximum number --> {b}. Minimum number --> {a}");
