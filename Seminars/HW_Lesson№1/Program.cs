﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите число №1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число №2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine("Число №1 больше числа №2");
// }
// else
// {
//     Console.WriteLine("Число №2 больше числа №1");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите число №1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число №2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число №3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2 && num1 > num3 )
// {
//     Console.WriteLine("Число №1 - максимальное число");
// }
// else if (num2 > num1 && num2 > num3 )
// {
//     Console.WriteLine("Число №2 - максимальное число");
// }
// else
// {
//     Console.WriteLine("Число №3 - максимальное число");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Введенное число - четное");
}
else
{
    Console.WriteLine("Введенное число - нечетное");
}