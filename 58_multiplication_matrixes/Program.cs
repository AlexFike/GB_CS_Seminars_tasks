// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}


// int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
// int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

Console.Clear();
int[,] testMatrix1 = GetArray(4, 5, 1, 5);
PrintArray(testMatrix1);
Console.WriteLine();
int[,] TestMatrix2 = GetArray(5, 4, 1, 5);
PrintArray(TestMatrix2);
Console.WriteLine();
PrintArray(MultMatrix(testMatrix1, TestMatrix2));
