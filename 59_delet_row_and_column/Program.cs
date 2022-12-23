// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


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

int[,] array = GetArray(5, 6, 1, 10);

(int, int) SearchPositionMinElem(int[,] array)
{
    int indexRow = 0;
    int indexCol = 0;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0 && j == 0)
            {
                indexRow = i;
                indexCol = j;
                min = array[i, j];
            }
            if (array[i, j] < min)
            {
                indexRow = i;
                indexCol = j;
                min = array[i, j];
            }
        }
    }
    return (indexRow, indexCol);
}

int[,] DelRowColumnPositionMinEl(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    (int indexRow, int indexCol) = SearchPositionMinElem(array);
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != indexRow)
        {
            l = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != indexCol)
                {
                    newArray[k, l] = array[i, j];
                    l++;
                }
            }
            k++;
        }
    }
    return newArray;
}


PrintArray(array);
Console.WriteLine();
int[,] newArray = DelRowColumnPositionMinEl(array);
PrintArray(newArray);

