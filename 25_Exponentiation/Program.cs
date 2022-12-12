// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number, int degree)
{
    int result = 1;

    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

void CallFunction(int number, int degree)
{
    if (degree < 1) Console.WriteLine("Not a natural degree!");
    else
    {
        Console.WriteLine($"{number} to the degree of {degree} = "
        + $"{Exponentiation(number, degree)}");
    }
}


CallFunction(3, 2);
