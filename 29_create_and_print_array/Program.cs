// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArrayRndInt(int length, int start, int end)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++) array[i] = new Random().Next(start, end);

    return array;
}
void PrinIntArray(int[] array)
{
    Console.Write("Our array => [");

    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");

    Console.Write($"{array[array.Length - 1]}]");
}

while (true)
{
    try
    {
        Console.Write("Input array size: ");
        int size = int.Parse(Console.ReadLine()!);

        Console.Write("Input starting point of random numbers: ");
        int s = int.Parse(Console.ReadLine()!);

        Console.Write("Input ending point of random numbers: ");
        int e = int.Parse(Console.ReadLine()!);

        PrinIntArray(CreateArrayRndInt(length: size, end: e, start: s));
        break;
    }
    catch
    {
        Console.WriteLine("Not valid data. Try it again=)");
    }
}
