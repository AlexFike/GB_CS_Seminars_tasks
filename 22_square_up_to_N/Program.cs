// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void RecSquare(int n, int i = 1)
{
    if (n == i)
    {
        Console.Write(i * i);
    }
    else
    {
        Console.Write($"{i * i} ");
        RecSquare(n, i + 1);
    }
}

RecSquare(9);