// Задача 1. Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36 

int SumNum(int num)
{
    int all_sum = 0;

    for(int i = 0; i <= num; i++)
        all_sum += i;

    return all_sum;
}

int val = int.Parse(Console.ReadLine()!);
int result = SumNum(val);
Console.WriteLine(result);