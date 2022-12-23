// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] matrix = {{1,2,3},
                {4,5,6},
                {7,8,9}};

int[,] ReplaceRowsMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int buff = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = buff;
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


PrinArray(ReplaceRowsMatrix(matrix));