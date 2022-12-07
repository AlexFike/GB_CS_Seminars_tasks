// Задача 20 Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


double distansPoints(int xA, int yA, int xB, int yB)
{
    double result = Math.Sqrt((Math.Pow((xB - xA), 2)) + (Math.Pow((yB - yA), 2)));

    return result;
}

Console.WriteLine(string.Format("{0:F3}", distansPoints(3, 6, 2, 1)));