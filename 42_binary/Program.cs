// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string ConvertToBinaryNumber(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

int number = 45;
Console.WriteLine($"{number} => {ConvertToBinaryNumber(number)}");
