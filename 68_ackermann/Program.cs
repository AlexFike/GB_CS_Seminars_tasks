// Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    return (m > 0 && n > 0) ? Ackermann(m - 1, Ackermann(m, n - 1)) :
           (m > 0 && n == 0) ? Ackermann(m - 1, 1) : n + 1;
}

Console.WriteLine(Ackermann(2, 3));
Console.WriteLine(Ackermann(3, 2));
