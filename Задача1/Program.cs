﻿/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SumPos(int[] array)
{
int product = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        product++;
}
Console.WriteLine(product);
}


Console.WriteLine("Введи длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] newarray = CreateRandomArray(length);
ShowArray(newarray);
SumPos(newarray);

