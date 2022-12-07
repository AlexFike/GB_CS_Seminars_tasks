// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void RecCube(int n, int i = 1)
{
    if (n == i)
    {
        Console.Write(i * i * i);
    }
    else
    {
        Console.Write($"{i * i * i} ");
        RecCube(n, i + 1);
    }
}

RecCube(5);
