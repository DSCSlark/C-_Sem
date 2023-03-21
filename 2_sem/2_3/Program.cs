// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

void Del(int a)
{
    Console.WriteLine(a);
    if (a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine($"Число {a} кратно 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число {a} не кратно 7 и 23");
    }
}

int random = new Random().Next(1, 1000);
Del (random);