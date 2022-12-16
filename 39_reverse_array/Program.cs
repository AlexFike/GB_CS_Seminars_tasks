//  Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArray(int length, int start, int end)
{
    int[] collection = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        collection[i] = rnd.Next(start, end);
    }
    return collection;
}

int[] ReverseArrayNewArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[array.Length - 1 - i];
    }
    return newArray;
}

int[] ReverseArray(int[] array)
{
    int length = array.Length / 2;
    for (int i = 0; i < length; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

int[] testArray = CreateArray(10, 1, 11);
Console.Write(string.Join(" ", testArray));
Console.WriteLine();
Console.Write(string.Join(" ", ReverseArrayNewArray(testArray)));
Console.WriteLine();
Console.Write(string.Join(" ", ReverseArray(testArray)));
