// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника


int[][] CreateArrayTringlePaskal(int number)
{
    int[][] array = new int[number][];
    for (int i = 0; i < number; i++)
    {
        array[i] = new int[i + 1];
        for (int j = 0; j < array[i].Length; j++)
        {
            if (j == 0 || j == array[i].Length - 1) array[i][j] = 1;
            else array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
        }
    }
    return array;
}

void PrintTringlePaskal(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string printStr = string.Empty;
        for (int j = 0; j < array[i].Length; j++)
        {
            if (j != array[i].Length - 1) printStr += array[i][j] + " ";
            else printStr += array[i][j];
        }
        Console.SetCursorPosition((Console.WindowWidth - printStr.Length) / 2,
                                  2 + i);
        Console.WriteLine(printStr);
    }
}

Console.Clear();
int[][] array = CreateArrayTringlePaskal(25);
PrintTringlePaskal(array);

