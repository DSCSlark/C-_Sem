// Напишите программу, которая на вход принимает число и выдаетколичество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int NumCount(int num)
{
    int count = 0;
    for(int i = 1; num > 0; i++)
    {
        num /= 10;
        count = i;
    }
    return count;
}

Console.WriteLine("Enter a number: ");
int a = int.Parse(Console.ReadLine()!);
int result = NumCount(a);
Console.WriteLine(result);