// Задача 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string binary(int num)
{
    string result = "";
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine()!);
string answer = binary(a);
Console.WriteLine(answer);