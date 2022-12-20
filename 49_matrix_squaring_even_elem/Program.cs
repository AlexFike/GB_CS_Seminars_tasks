// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int[,] GetArray(int m, int n, int start, int end)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(start, end);
        }
    }
    return array;
}


int[,] ReplaceElemEvenIndexSquaring(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0) array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.Write("Input rows array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Input columns array: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Input start rnd: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Input end rnd: ");
int end = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, columns, start, end);

PrintArray(array);
Console.WriteLine();
PrintArray(ReplaceElemEvenIndexSquaring(array));

