﻿// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

bool TriangleCheck(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine(TriangleCheck(1, 1, 1));


