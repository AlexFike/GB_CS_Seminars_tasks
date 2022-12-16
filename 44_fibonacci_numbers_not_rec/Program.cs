// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] Fibonacci(int number)
{
    int[] array = new int[number];
    if (number >= 2) array[1] = 1;
    for (int i = 2; i < number; i++) array[i] = array[i - 1] + array[i - 2];
    return array;
}

Console.Write(string.Join(" ", Fibonacci(7)));