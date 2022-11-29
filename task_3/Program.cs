// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("input number: ");
int number = int.Parse(Console.ReadLine()!);

switch(number)
{
    case 1:
        Console.Write("Monday");
        break;
    case 2:
        Console.Write("Tuesday");
        break;
    case 3:
        Console.Write("Wednesday");
        break;
    case 4:
        Console.Write("Thursday");
        break;
    case 5:
        Console.Write("Friday");
        break;
    case 6:
        Console.Write("Saturday");
        break;
    case 7:
        Console.Write("Sunday");
        break;
    default:
        Console.Write("Is not a valid week number");
        break;
}
