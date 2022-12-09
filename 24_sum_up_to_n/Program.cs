// Задача 24: Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSumNums(int n, int i = 1)
{
    if (i == n) return n;
    else return i + GetSumNums(n, i + 1);
}

Console.WriteLine(GetSumNums(5));
