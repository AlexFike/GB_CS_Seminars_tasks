// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GetSpiralMatrix(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    int count = 1;
    int left = 0;
    int right = 0;
    int i = 0;
    int j = 0;
    int poinBreak = columns * rows;
    while (count < poinBreak)
    {
        for (j = right, i = left; j < columns - right; j++, count++)
        {
            result[i, j] = count;
            // Console.WriteLine("j++ " + count);
            if (count == poinBreak) break;
        }
        right++;
        for (i = right, j = j - 1; i < rows - left; i++, count++)
        {
            result[i, j] = count;
            // Console.WriteLine("i++ " + count);
            if (count == poinBreak) break;
        }
        for (i = i - 1, j = j - 1; j >= left; j--, count++)
        {
            result[i, j] = count;
            // Console.WriteLine("j-- " + count);
            if (count == poinBreak) break;
        }
        left++;
        for (i = i - 1, j = j + 1; i >= right; i--, count++)
        {
            result[i, j] = count;
            // Console.WriteLine("i-- " + count);
            if (count == poinBreak) break;
        }
    }
    return result;
}


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:00}", array[i, j]) + " ");

        }
        Console.WriteLine();
    }
}



int[,] testMatrix = GetSpiralMatrix(7, 5);
PrintMatrix(testMatrix);
