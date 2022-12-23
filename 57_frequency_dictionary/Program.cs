// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

using System.Collections.Generic;
int[,] matrix = { { 1, 2, 3, 4 }, { 2, 5, 7, 8 }, { 9, 2, 1, 7 }, { 9, 1, 2, 3 } };



List<int> DictUniqNumber(int[,] array)
{
    List<int> UniqNumbers = new List<int> { };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0 && j == 0) UniqNumbers.Add(array[i, j]);
            bool tm = true;
            for (int k = 0; k < UniqNumbers.Count; k++)
            {
                if (UniqNumbers[k] == array[i, j])
                {
                    tm = false;
                }
            }
            if (tm == true)
            {
                UniqNumbers.Add(array[i, j]);
            }

        }
    }
    return UniqNumbers;
}


void PrintCountDict(int[,] array)
{
    List<int> UniqNumbers = DictUniqNumber(array);

    for (int i = 0; i < UniqNumbers.Count; i++)
    {
        int count = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (UniqNumbers[i] == array[j, k]) count++;
            }
        }
        Console.Write($"{UniqNumbers[i]} => {count} times; ");
    }

}


PrintCountDict(matrix);
