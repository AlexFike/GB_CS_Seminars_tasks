// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System.Collections.Generic;


List<int> GeneratedUniqueNumbers(int lenght, int start, int end)
{
    List<int> UniqNumbers = new List<int> { };
    Random rnd = new Random();
    if (end - start < lenght) lenght = end - start;
    if (end < start)
    {
        UniqNumbers.Add(0);
        return UniqNumbers;
    }
    for (int i = 0; i < lenght; i++)
    {
        int newNumber = rnd.Next(start, end);
        for (int j = 0; j < UniqNumbers.Count(); j++)
        {
            if (newNumber == UniqNumbers[j])
            {
                newNumber = rnd.Next(start, end);
                j = 0;
            }
        }
        UniqNumbers.Add(newNumber);
    }
    return UniqNumbers;
}


int[,,] Get3dMatrixUniqueElement(int m, int n, int x, int start, int end)
{
    int[,,] result = new int[m, n, x];

    int lenght = result.GetLength(0) * result.GetLength(1) * result.GetLength(2);

    List<int> UniqNumbers = GeneratedUniqueNumbers(lenght, start, end);

    int count = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = UniqNumbers[count];
                count++;
            }
        }
    }
    return result;

}


void Print3dMatrixInt(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] testMatrix = Get3dMatrixUniqueElement(2, 2, 2, 10, 100);

Print3dMatrixInt(testMatrix);

