using System.Data;
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = 0, result = 0;

// if(number < 100000 && number > 10000){
// result = number % 100;
// while(number > 100){
//     number/=10;
// }
// temp = number/10;
// number %= 10;
// temp = number * 10 + temp;
// if(temp == result){
//     Console.WriteLine("Полиндром");
// }
// else Console.WriteLine("Не полиндром");
// }
// else Console.WriteLine("Введите пятизначное число!");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты ax, ay, az для точки А: ");
// double ax = Convert.ToDouble(Console.ReadLine());
// double ay = Convert.ToDouble(Console.ReadLine());
// double az = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты bx, by, bz для точки В: ");
// double bx = Convert.ToDouble(Console.ReadLine());
// double by = Convert.ToDouble(Console.ReadLine());
// double bz = Convert.ToDouble(Console.ReadLine());

// double distans = Math.Sqrt(Math.Pow((ax-bx), 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2));

// Console.WriteLine($"Расстояние между А и В = {Math.Round(distans, 3)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for( double i = 1; i <= n; i++){
//     double result = Math.Pow(i, 3);
//     Console.WriteLine($" {result} ");
// }

