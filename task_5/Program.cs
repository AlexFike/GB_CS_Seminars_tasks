// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("input number: ");
int number = Math.Abs(int.Parse(Console.ReadLine()!));

int end = number * 2 + 1;
int result = number * -1;

for (int i = 0; i < end; i++)
{
    Console.Write($"{result + i} ");
}
