// Задача 26:
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Find(int num)
{
    int sum = 0;
    while (num > 0)
    {
        num /= 10;
        sum++;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine($"В числе {number} цифр: {Find(number)}");
}
else Console.WriteLine("Введите положительное число.");
