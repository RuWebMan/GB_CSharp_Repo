﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
void CreateArrayMethod(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArrayMethod(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}    

int EvenNumberMethod(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if(array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

int[] array = new int[8];
CreateArrayMethod(array);
PrintArrayMethod(array);
EvenNumberMethod(array);
Console.WriteLine($"Чётных чисел в массиве: {EvenNumberMethod(array)}");
*/

