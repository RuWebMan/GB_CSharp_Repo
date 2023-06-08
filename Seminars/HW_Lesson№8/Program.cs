// Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void CreateArrayMethod(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArrayMethod(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

/*
void SortArrayMethod(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
                }
            }
        }
    }
}

int[,] array = new int[3, 4];
Console.WriteLine();
Console.WriteLine("Исходный массив:");
CreateArrayMethod(array);
PrintArrayMethod(array);
Console.WriteLine();
Console.WriteLine("Упорядоченный по убыванию массив:");
SortArrayMethod(array);
PrintArrayMethod(array);
Console.WriteLine();
*/

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
void SerchSmalSumMethod(int[,] arr)
{
    int sum = 0;
    int min = 0;
    int index = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                sum += arr[i, k];
            }
            if (sum < min || min == 0)
            {
                min = sum;
                index = i;
            }
        }
    }
    Console.WriteLine($"В строке {index + 1} наименьшая сумма элементов = {min}");
}

int[,] array = new int[3, 4];
Console.WriteLine();
CreateArrayMethod(array);
PrintArrayMethod(array);
Console.WriteLine();
SerchSmalSumMethod(array);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
void MatrixMultiplicationMethod(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    int result = 0;
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            result = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = result;
        }
    }
}

int[,] matrixA = new int[2, 2];
int[,] matrixB = new int[2, 2];
int[,] matrixC = new int[2, 2];

Console.WriteLine("Матрица А:");
CreateArrayMethod(matrixA);
PrintArrayMethod(matrixA);
Console.WriteLine("Матрица В:");
CreateArrayMethod(matrixB);
PrintArrayMethod(matrixB);
MatrixMultiplicationMethod(matrixA, matrixB, matrixC);
Console.WriteLine("Результирующая Матрица :");
PrintArrayMethod(matrixC);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
