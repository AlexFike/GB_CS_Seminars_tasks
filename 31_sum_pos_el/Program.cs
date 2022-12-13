// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

int[] FillArrayRndInt(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(minValue, maxValue);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array = FillArrayRndInt(CreateArray(12), -9, 9);
int sumPos = 0;
int sumNeg = 0;

foreach (int item in array)
{
    if (item > 0) sumPos += item;
    else sumNeg += item;
}

PrintArray(array);
Console.Write($" => Sum of positive elements = {sumPos}. Sum of negative elements = {sumNeg}");

