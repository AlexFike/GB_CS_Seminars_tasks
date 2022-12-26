// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string NumbersUpToN(int n, int i = 1)
{
    return (i < n) ? i + " " + NumbersUpToN(n, i + 1) : $"{n}";
}

Console.WriteLine(NumbersUpToN(5));
