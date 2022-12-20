// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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


void PrintSumMainDiagonal(int[,] array)
{
    int result = 0;
    int length = Math.Min(array.GetLength(0), array.GetLength(1));
    for (int i = 0; i < length; i++)
    {
        // for (int j = 0; j < array.GetLength(1); j++)
        // {
        //     if (i == j)
        // {
        result += array[i, i];
        if (i == length - 1)
        {
            Console.Write($"{array[i, i]} = ");
        }
        else
        {
            Console.Write($"{array[i, i]} + ");
        }
        // j = array.GetLength(1);
        // }
        // }
    }
    Console.Write(" " + result);
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
PrintSumMainDiagonal(array);

