// Напишите программу, которая на вход принимает координаты точки (X и Y), при чем Х ≠ 0 или У ≠ 0 и выдает номер четверти в плоскости, в которой находится эта точка.
// Если "х" движется в правую сторону, это +
// Если "х" движется в левую сторону, это -
// Если "у" движется вверх, это +
// Если "у" движется вниз, это -

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0, y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);