﻿// Задача 28: 
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int prod = 1;
if (num > 1)
{
    for (int i = 1; i <= num; i++)
    {
        prod = prod * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} = {prod}");
}
else Console.WriteLine("Введите число большее нуля!!!");
