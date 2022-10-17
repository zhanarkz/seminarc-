﻿// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int [] FillArray(int num)
{
   int[] array = new int[num];
   Random rnd = new Random();
   for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");//vivodim do sapyatoi
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[] myArray = FillArray(8);
PrintArray(myArray);