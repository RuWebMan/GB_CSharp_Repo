//using Internal;
using System.Dynamic;
using System;
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void CreateArrayMethod(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine("Введите число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
        
//     }
// }

// void PrintArrayMethod(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
// }   

// int PositivInArray(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum++;
//         }
//     }
//     return sum;
// }

// int[] newArray = new int[5];
// CreateArrayMethod(newArray);
// PrintArrayMethod(newArray);
// Console.WriteLine($"Чисел больше ноля: {PositivInArray(newArray)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine();

Console.Write ($"Введите значения b1,: ");
double b1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ($"Введите значения k1,: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write ($"Введите значения b2,: ");
double b2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ($"Введите значения k2,: ");
double k2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine();

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения: ({x}, {y})");
}
IntersectionPoint(b1, k1, b2, k2);
Console.WriteLine();


