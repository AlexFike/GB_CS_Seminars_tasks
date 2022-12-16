// Напишите программу, которая будет 
// создавать копию заданного массива
// с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++) newArray[i] = array[i];
    return newArray;
}


int[] testArray = { 1, 3, 4, 5, 6, 7, 8 };

int[] newTestArray = CopyArray(testArray);

Console.Write(string.Join(" ", testArray));
Console.WriteLine();
Console.Write(string.Join(" ", newTestArray));

