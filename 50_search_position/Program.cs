// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец


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

int[,] array = GetArray(4, 4, 1, 100);

void SearchElementInMatrix(int[,] array)
{
    int count = 5;
    while (true)
    {
        Console.WriteLine("Input position of element ↓");
        Console.Write("rows => ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("columns => ");
        int columns = int.Parse(Console.ReadLine()!);
        try
        {
            Console.Write($"{array[rows, columns]}");
            Console.Write($" <= element in position with indexes [{rows}, {columns}]");
            break;
        }
        catch
        {
            Console.WriteLine("There is no such position or you have entered incorrect data!");
            count--;
            if (count == 0)
            {
                Console.WriteLine("0 attempts! try it another time...");
                break;
            }
            else if (count == 1) Console.WriteLine("More 1 attempt!");
            else Console.WriteLine($"More {count} attempts");
        }


    }
}

PrinArray(array);
SearchElementInMatrix(array);

