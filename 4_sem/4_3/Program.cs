// Напишите программу, которая будет создавать массив из 8 элементов, заполенный нулями и единицами в случайном порядке.

void binArr(int num)
{
    int[] arr = new int[num];
    for(int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(2);
        Console.Write($"{arr[i]}, ");
    }
    //Console.WriteLine("[{0}]", string.Join(", ", arr));
}
Console.WriteLine("Введите длину массива: ");
int len = int.Parse(Console.ReadLine()!);
binArr(len);
