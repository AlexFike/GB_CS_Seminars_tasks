//  Задайте значение N. Напишите программу, 
//  которая выведет все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersUpToN(int n)
{
    return (n > 1) ? (n + " ") + NumbersUpToN(n - 1) : "1";
}
Console.WriteLine(NumbersUpToN(5));
Console.WriteLine(NumbersUpToN(8));