// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.OutputEncoding = System.Text.Encoding.Unicode;

int number = 3;
int degree = 5;

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


int Exponentiation(int number, int degree)
{
    return (degree > 1) ? number * (Exponentiation(number, degree - 1)) : number;
}


char[] array = degree.ToString().ToCharArray();

Console.Write($"({number}");
foreach (var item in array) Console.Write($"{Udegree[item]}");
Console.Write($") => {Exponentiation(number, degree)}");
