// Задача 1. Напишите программу, которая на вход принимает три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

void Treugolnik(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

Treugolnik(a, b, c);