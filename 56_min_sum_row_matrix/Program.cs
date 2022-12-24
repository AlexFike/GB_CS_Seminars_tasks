// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


(int, int) MinSumRowMatrix(int[,] array)
{
    int rowMinSum = 0, minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) minSum += array[i, j];
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    return (rowMinSum + 1, minSum);
}


int[,] testArray = GetArray(5, 4, 1, 10);
PrintArray(testArray);
Console.WriteLine();
(int row, int sumRow) = MinSumRowMatrix(testArray);
Console.Write($"String with min sum {sumRow} => {row}");

