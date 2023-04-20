﻿// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fib(int num)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
}

int n = int.Parse(Console.ReadLine()!);
Fib(n);
