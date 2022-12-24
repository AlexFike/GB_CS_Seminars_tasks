// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void SelectSort(int[,] array, int k)
{
    for (int i = 0; i < array.GetLength(1) - 1; i++)
    {
        int max = i;
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (array[k, j] > array[k, max]) max = j;
        }
        if (max != i)
        {
            int buff = array[k, i];
            array[k, i] = array[k, max];
            array[k, max] = buff;
        }

    }
}


int[,] SortMatrixRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SelectSort(array, i);
    }
    return array;
}


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


int[,] testArray = GetArray(5, 5, 1, 10);
PrintArray(testArray);
Console.WriteLine();
SortMatrixRow(testArray);
PrintArray(testArray);

