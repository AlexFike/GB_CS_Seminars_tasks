// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponentiation(double number, int degree)
{
    double result = 1;

    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

var Udegree = new Dictionary<char, char>()
    {
        {'0', '⁰'},
        {'1', '¹'},
        {'2', '²'},
        {'3', '³'},
        {'4', '⁴'},
        {'5', '⁵'},
        {'6', '⁶'},
        {'7', '⁷'},
        {'8', '⁸'},
        {'9', '⁹'}
    };

int countControl = 5;
int count = countControl;

while (true)
{
    try
    {
        Console.Write($"Input number and natural degree. Attempts: {count} out {countControl}: ");
        string[] temporaryStr = Console.ReadLine()!.Split();
        double number = double.Parse(temporaryStr[0]);
        int degree = int.Parse(temporaryStr[1]);

        Console.OutputEncoding = System.Text.Encoding.Unicode;

        char[] array = degree.ToString().ToCharArray();

        Console.Write($"({number}");
        foreach (var item in array) Console.Write($"{Udegree[item]}");
        Console.Write($") = {Exponentiation(number, degree)}");
        break;
    }
    catch
    {
        count--;
    }
    if (count == 0)
    {
        Console.WriteLine("You have exhausted the number of attempts");
        break;
    }
}


