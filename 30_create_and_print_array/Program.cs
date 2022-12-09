// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 2);

    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]} => all elements of the array");
        else Console.Write(array[i] + " ");
    }
}


Console.Write("Input size of the array: ");

PrintArray(CreateArray(int.Parse(Console.ReadLine()!)));
