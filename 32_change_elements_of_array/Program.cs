// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateArrayRndInt(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(start, end);
    return array;
}

int[] ChangeElemArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array) Console.Write($"{item} ");
}

int[] array = CreateArrayRndInt(5, -10, 10);

PrintArray(array);
Console.WriteLine();
PrintArray(ChangeElemArray(array));

