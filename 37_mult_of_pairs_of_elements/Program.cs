// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(start, end);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (var item in array) Console.Write($"{item} ");
    Console.Write("]");
}


int[] MultPairArray(int[] array)
{
    int[] newArray = new int[array.Length / 2 + array.Length % 2];

    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == array.Length - 1 - i)
        {
            newArray[i] = array[i];
        }
        else
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    return newArray;
}


int[] array = CreateArrayRndInt(6, 1, 10);
PrintArray(array);
PrintArray(MultPairArray(array));
