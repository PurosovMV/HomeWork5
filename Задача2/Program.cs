/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
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

void Sum(int[] array)
{
    int product = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        product += array[i]++;
    }
    Console.WriteLine(product);
}


Console.WriteLine("Введи длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] newarray = CreateRandomArray(length);
ShowArray(newarray);
Sum(newarray);