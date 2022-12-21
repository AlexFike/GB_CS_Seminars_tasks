// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n, int start, int end)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int tm = rnd.Next(0, 2);
            if (tm == 0) array[i, j] = rnd.Next(start, end);
            else array[i, j] = Math.Round((rnd.Next(start, end) + rnd.NextDouble()), 1);

        }
    }
    return array;
}


void PrintArray(double[,] array)
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

double[,] array = GetArray(rows, columns, start, end);

PrintArray(array);



