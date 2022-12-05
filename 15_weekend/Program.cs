// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();

void Weekend(int number)
{
    if(number == 7 || number == 6)
    {
        Console.WriteLine("Yes");
    }
    else if(number < 6 && number > 0)
    {
        Console.WriteLine("No");
    }
    else
    {
        Console.WriteLine("Is not a valid week number");
    }
}


Console.Write("Input day of week: ");
Weekend(int.Parse(Console.ReadLine()!));