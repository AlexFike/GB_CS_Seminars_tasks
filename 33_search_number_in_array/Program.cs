// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



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

void NumberInArray(int[] array, int number)
{
    bool tm = false;

    foreach (var item in array)
    {
        if (item == number)
        {
            Console.WriteLine(" => Yes!!");
            tm = true;
            break;
        }
    }
    if (tm == false)
    {
        Console.WriteLine(" => No!");
    }
}


int[] array = CreateArrayRndInt(10, 1, 10);
Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"Search {num} => ");
PrintArray(array);
NumberInArray(array, num);