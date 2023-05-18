﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ExponentiationMethod(int a, int b) 
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} в степени {b} = {ExponentiationMethod(a, b)}");

//int res = ExponentiationMethod(2,3);
