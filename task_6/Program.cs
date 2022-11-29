// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.Write("Input number: ");
try
{
    if (int.Parse(Console.ReadLine()!) % 2 == 0) Console.Write("Even number");
    else Console.Write($"Not is even namber");
}
catch
{
    Console.Write("Not valid data");
}
