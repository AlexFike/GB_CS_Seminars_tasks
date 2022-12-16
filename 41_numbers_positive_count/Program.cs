// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int NumbersPositivCount(string[] collection)
{
    int count = 0;
    foreach (var item in collection)
    {
        if (int.Parse(item) > 0) count++;
    }
    return count;
}

Console.Write("Input number by space: ");
string[] array = Console.ReadLine()!.Split();

Console.WriteLine(NumbersPositivCount(array));
