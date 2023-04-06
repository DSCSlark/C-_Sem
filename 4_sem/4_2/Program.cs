// 2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ymn(int num)
{
    int x = 1;
    for(int i = 1; i <= num; i++)
    {
        x *= i;
    }
    return x;
}

Console.WriteLine("Write a number: ");
int P = ymn(int.Parse(Console.ReadLine()!));
Console.WriteLine(P);
