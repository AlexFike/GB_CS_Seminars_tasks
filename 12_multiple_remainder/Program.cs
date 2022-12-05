// №12 Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();

Console.Write("Input first number: ");
int numberF = int.Parse(Console.ReadLine()!);

Console.Write("Input second number: ");
int numberS = int.Parse(Console.ReadLine()!);

if (Math.Abs(numberS) > Math.Abs(numberF)) //не обязательное условие, но просто захотелось)
{                                         // меняем числа местами, если модуль второго числа
    int swap = numberF;                   // больше первого 
    numberF = numberS;
    numberS = swap;
}

int result = numberF % numberS; // Выявляем остаток, убивая двух зайцев. 

if (result == 0)
{
    Console.WriteLine($"The number {numberF} is a multiple of {numberS}");
}
else
{
    Console.WriteLine($"The number {numberF} is not a multiple of {numberS}. Remainder = {result}");
}

