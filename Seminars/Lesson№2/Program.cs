//Циклы, break, continue

// int x = 5;
// while(x > 0){
//     x--;
//     if(x == 3) 
// continue;
    
// Console.WriteLine($"{x} 111");

//break - прерывает выполнение цикла
//continue - прерывает выполнение цикла и возвращяет в начало цикла
// } 
// Console.WriteLine("OK");

// for (int i = 0; i < 10; i++) //переменная i существует только внутри цикла
// {
//     Console.WriteLine($"{i} 111");
// }
// Console.WriteLine("OK");
//Console.WriteLine($"{i} 111"); //тут переменная i не существует

// //математические функции, Random.Next() 
// double x = -7; 
// double result = Math.Abs(x); // получаем абсолютное число, модуль |x|
// Console.WriteLine(result);

//округление дробного числа до нужного количества знаков
// x = 7.12345;
// result = Math.Round(x, 1); // х - переменная, 1 - количество символов после запятой
// Console.WriteLine(result);

// x = 7.62345;
// result = Math.Floor(x); //математическое округление, 7,62 = 8
// Console.WriteLine(result);

// //математические функции для поиска максимума и минимума
// x = 7.45;
// double y = 3.845;
// result = Math.Max(x, y);
// Console.WriteLine(result);
// result = Math.Min(x, y);
// Console.WriteLine(result);

//возведение в корень и извлечение
// x = 4; y =3;
// result = Math.Pow(x, y); // возвести
// Console.WriteLine(result);
// result = Math.Sqrt(x); //извлечь
// Console.WriteLine(result);

// int x = 0; 
// for (int i = 0; i < 10; i++)
// {
//     x = new Random().Next(1, 10);
//     Console.WriteLine($"{i} {x}");
// }

// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int x = new Random().Next(10, 100);
// Console.WriteLine(x);
// int x1 = x/10; //есть число 2х значное, находит перый символ
// int x2 = x%10; // находит второй символ 
// if(x1 > x2){
//     Console.WriteLine(x1);
// }
// else Console.WriteLine(x2);

// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int x = new Random().Next(100, 1000);
// Console.WriteLine(x);
// int x1 = x/100;
// int x2 = x%10;
// Console.WriteLine($"{x1}{x2}");

// int result = x1 * 10 + x2;
// Console.WriteLine(result);

// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int result = x % y;

// if(result == 0){
//     Console.WriteLine("Кратно");
// }
// else Console.WriteLine($"Не кратно, остаток {result}");

// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно. 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if(x % 7 == 0 && x % 23 == 0){
//     Console.WriteLine("Да");
// }
// else Console.WriteLine($"Нет");

// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if( Math.Pow(x, 2) == y || Math.Pow(y, 2) == x){
//     Console.WriteLine("Да");
// } else Console.WriteLine("Нет");


// Напиши программу,  где вводим три числа, а потом выводим сумму только 
//положительных чисел.

// Console.Write("Введите три числа массива: ");
// int[] x = new int[3];
// int sum = 0;

// for (int i = 0; i < 3; i++)
// {
//     x[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < 3; i++)
// {
//     if(x[i] >= 0){
//         sum = sum + x[i];
//     }
// }
// Console.Write(sum);

// У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// 	​Необходимо составить код, который находит их пересечение.
// 	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
// 	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».

// -10 -9 -8 -7 -6 -5 -4 -3 -2 -1 0 1 2 3 4 5 6 7 8 9 10

// Console.WriteLine("Введите первые координаты: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторые координаты: ");
// int x3 = Convert.ToInt32(Console.ReadLine());
// int x4 = Convert.ToInt32(Console.ReadLine());
// int max1, max2;

// if(x1 < x3){
//      max1 = x3;
//     }
// else max1 = x1;
// if(x2 < x4){
//     max2 = x2;
//     }
// else max2 = x4;
// int result = max2 - max1;
// if(result < 0){
//     Console.WriteLine("0");
// }else Console.WriteLine(result);

