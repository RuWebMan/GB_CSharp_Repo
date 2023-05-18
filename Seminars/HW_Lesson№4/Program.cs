using System;
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int ExponentiationMethod(int a, int b) 
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

// Console.WriteLine("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{a} в степени {b} = {ExponentiationMethod(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumMethod(int a)
// {
//     int sum = 0;
//     while (a > 0)
//     {
//         sum += a % 10;
//         a /= 10;
//     }
//     return sum;

// }

// Console.WriteLine("Введите число : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {a}  = {SumMethod(a)}");

