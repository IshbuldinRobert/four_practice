// Задача 24:
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine($"{sum}");

}
else Console.WriteLine("Введите положительное число (:_:)");