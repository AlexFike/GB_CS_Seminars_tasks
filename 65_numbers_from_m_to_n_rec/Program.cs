// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

string NumbersFromMToN(int m, int n)
{
    return (m < n) ? m + " " + NumbersFromMToN(m + 1, n) : $"{m}";
}

Console.WriteLine(NumbersFromMToN(1, 5));
Console.WriteLine(NumbersFromMToN(4, 8));

