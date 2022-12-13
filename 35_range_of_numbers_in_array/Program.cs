// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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


int CountElemArray(int[] array, int min, int max)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > min && item < max) count++;
    }
    return count;
}


int[] array = CreateArrayRndInt(123, 0, 1000);
int minValue = 10;
int maxValue = 99;

PrintArray(array);
Console.Write($" Count from {minValue} to {maxValue} = {CountElemArray(array, minValue, maxValue)}");