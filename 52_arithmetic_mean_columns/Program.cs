// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrinArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMeanColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int col = 0; col < array.GetLength(1); col++)
    {
        double sumColumn = 0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sumColumn += array[rows, col];
        }
        result[col] = Math.Round(sumColumn / (array.GetLength(0)), 1);
    }

    return result;
}

int[,] array = GetArray(3, 4, 1, 100);
PrinArray(array);
Console.WriteLine();
Console.Write(string.Join(" ", ArithmeticMeanColumns(array)));


