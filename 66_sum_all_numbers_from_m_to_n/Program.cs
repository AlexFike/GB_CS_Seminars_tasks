// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumAllNumbersFromMtoN(int m, int n)
{
    return (m < n) ? m + SumAllNumbersFromMtoN(m + 1, n) : m;
}

Console.WriteLine(SumAllNumbersFromMtoN(1, 15));
Console.WriteLine(SumAllNumbersFromMtoN(4, 8));