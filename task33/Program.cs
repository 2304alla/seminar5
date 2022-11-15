// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да 

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


bool FindNumArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.Readline());

Console.WriteLine("Ведите число");
int number=Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArraeRndInt(12, 2, 9);
PrintArray(arr);
bool result = FindNumArray(arr,number);
Console.WriteLine(result ? "Да" :"Нет");
