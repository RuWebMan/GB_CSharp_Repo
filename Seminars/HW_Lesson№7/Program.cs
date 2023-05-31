//using Internal;
using System;

// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void CreateArrayMethod(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = Math.Round((new Random().NextDouble() * 10), 1);
//         }
//     }
// }
// void PrintArrayMethod(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

//  double [,] array = new double[3, 4];
// CreateArrayMethod(array);
// PrintArrayMethod(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void FillArrayMethod(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArrayMethod(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchNumber(int[,] arr)
// {
//     Console.Write("Введите x: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите y: ");
//     int y = Convert.ToInt32(Console.ReadLine());
//     if (x < 0 || x >= arr.GetLength(0) || y < 0 || y >= arr.GetLength(1))
//     {
//         Console.WriteLine($"Элемента с  координатами ({x}, {y}) - нет в массиве.");
//     }
//     else
//     {
//         Console.WriteLine($"Значение элемента с координатами ({x}, {y}): {arr[x, y]}");
//     }
// }

// int[,] array = new int[3, 4];
// FillArrayMethod(array);
// PrintArrayMethod(array);
// SearchNumber(array);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void FillArrayMethod(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArrayMethod(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ArithmeticMean(int[,] arr)
// {
//     int rows = arr.GetLength(0);
//     int cols = arr.GetLength(1);

//     for (int j = 0; j < cols; j++) 
//      {
//       double sum = 0;

//      for (int i = 0; i < rows; i++) 
//      {
//         sum += arr[i, j];
//      }

//       double average = sum / rows;
//       Console.WriteLine($"Среднее арифметическое {j + 1} столбца: {Math.Round(average, 2)}");
//      }
// }

// int[,] array = new int[3, 4];
// FillArrayMethod(array);
// Console.WriteLine();
// PrintArrayMethod(array);
// Console.WriteLine();
// ArithmeticMean(array);
// Console.WriteLine();