// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

double[] CreateArrayRndDecimal(int size, double sequence)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().NextDouble() * sequence;
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{Math.Round(array[i], 2)}, ");
    Console.Write($"{Math.Round(array[array.Length - 1], 2)}]");
}

double DifferenceMinMaxArray(double[] collection)
{
    double min = collection[0];
    double max = collection[0];
    foreach (var item in collection)
    {
        if (item > max) max = item;
        if (item < min) min = item;
    }
    return max - min;

}

double[] testArray = CreateArrayRndDecimal(10, 100);
PrintArray(testArray);
Console.Write($" => {Math.Round(DifferenceMinMaxArray(testArray), 2)}");
Console.WriteLine();
PrintArray(testArray);
Console.Write($" => {Math.Round((testArray.Max() - testArray.Min()), 2)}");

