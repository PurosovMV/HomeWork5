
/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

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

void Product(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else
        if (array[i] < min) min = array[i];
    }

    Console.WriteLine(max - min);

}


Console.WriteLine("Введи длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] newarray = CreateRandomArray(length);
ShowArray(newarray);
Product(newarray);




