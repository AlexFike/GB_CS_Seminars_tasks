// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int ThirdDigit(int number, int digit)
{
    int div = Convert.ToInt32(Math.Pow(10, digit));

    int result = number;

    while (result / div != 0)
    {
        result = result / 10;
    }

    result = result % 10;

    return result;
}

char ThirdDigitStr(string number, int digit)
{
    return number[digit - 1];
}

void CallFunction(string arg, int digit)
{
    int numberTest = new Random().Next(1, 1000000);
    if (arg == "string")
    {
        string numberTestStr = Convert.ToString(numberTest);

        if (numberTestStr.Length < digit)
        {
            Console.WriteLine($"{numberTestStr} does not contain 3 digits");
        }
        else Console.WriteLine($"Third digit {numberTest} = {ThirdDigitStr(numberTestStr, digit)}");

    }
    if (arg == "int")
    {
        if (numberTest / Convert.ToInt32(Math.Pow(10, digit - 1)) == 0)
        {
            Console.WriteLine($"{numberTest} does not contain 3 digits");
        }
        else Console.WriteLine($"Third digit {numberTest} = {ThirdDigit(numberTest, digit)}");
    }
}

Console.Write("Input setеing int or string: ");
string setArg = Console.ReadLine()!;

Console.Write("Input digit pull: ");
int number = int.Parse(Console.ReadLine()!);

CallFunction(setArg, number);



