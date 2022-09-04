﻿// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34");
int[] numbers = new int[10];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
    Console.Write(array[i] + ", ");
    }
  Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++ )
    {
    if (array[i] % 2 == 0)
     {
      quantity++;
     }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
Console.WriteLine();
Console.WriteLine("Массив со случайных положительных трехзначных чисел:");
WriteArray(numbers);
int quantity = QuantityPositive(numbers);
Console.WriteLine($"количество чётных чисел в данном массиве: {quantity}.");