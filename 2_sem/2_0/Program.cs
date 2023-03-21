// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

// 123 % 10 -> 3
// 123 // 10 -> 12

int th_num = new Random().Next(100, 1000);
int result = TakeNum(th_num);
Console.WriteLine(result);