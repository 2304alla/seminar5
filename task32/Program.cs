﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateArraeRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void ChangeElem(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }

}


int[] arr = CreateArraeRndInt(12, -9, 9);
PrintArray(arr);

ChangeElem(arr);
Console.WriteLine("Замена элементов массива на соответсвующие с противоположным знаком");
PrintArray(arr);



// Console.WriteLine("Введите колличество элементов массива: ");
// int length = Convert.ToInt32(Console.Readline());

// Console.WriteLine("Введите колличество элементо массива: ");
// int minNum = Convert.ToInt32(Console.Readline());

// Console.WriteLine("Введите колличество элементов массива: ");
// int naxNum = Convert.ToInt32(Console.Readline());
