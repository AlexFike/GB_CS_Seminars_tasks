// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8 


int numberRnd = new Random().Next(10,100);

int result = Math.Max(numberRnd / 10, numberRnd % 10);

Console.WriteLine($"Maximum digit = {result}");