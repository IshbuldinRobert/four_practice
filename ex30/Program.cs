// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr0or1 = new int[8];

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) // для красоты
        {
            Console.Write($"{arr[i]}");
        }
        else Console.Write($"{arr[i]}, ");
    }
}

FillArr(arr0or1);
Console.Write("["); // для красоты
PrintArr(arr0or1);
Console.Write("]"); // для красоты