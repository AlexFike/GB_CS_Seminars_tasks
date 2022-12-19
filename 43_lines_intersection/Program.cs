// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double, double) LinesIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return (x, k2 * x + b2);
}

void CheckLinesIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Straight lines match");
    else if (k1 == k2) Console.WriteLine("Straight lines are parallel");
    else Console.WriteLine("Coordinates of the intersection point => "
                            + LinesIntersection(b1, k1, b2, k2));
}

CheckLinesIntersection(2, 5, 4, 9);