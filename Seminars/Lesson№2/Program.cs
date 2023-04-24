//Циклы, break, continue

// int x = 5;
// while(x > 0){
//     x--;
//     if(x == 3) continue;
    
//     Console.WriteLine($"{x} 111");
//  //break - прерывает выполнение цикла
//  //continue - возвращяет в начало цикла
// } 
// Console.WriteLine("OK");

for (int i = 0; i < 10; i++) //переменная i существует только внутри цикла
{
    Console.WriteLine($"{i} 111");
}
Console.WriteLine("OK");
//Console.WriteLine($"{i} 111"); //тут она уже не работает. прога ее не видит

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

 int x = new Random().Next(10, 100);

 int x1 = x / 10;
 int x2 = x % 10;
Console.WriteLine($"{x}");
if (x1 > x2)
   Console.WriteLine($"{x1}");
else
   Console.WriteLine($"{x2}");

   11) Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int x1 = x/100;
int x2 = x%10;
Console.WriteLine($"{x1}{x2}");

int result = x1 * 10 + x2;
Console.WriteLine(result);

12) Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

Console.Write("Введите 2 числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int result = x % y;

if(result == 0){
    Console.WriteLine("Кратно");
}
else Console.WriteLine($"Не кратно, остаток {result}");

Задача №14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if(x % 7 == 0 && x % 23 == 0){
    Console.WriteLine("Да");
}
else Console.WriteLine($"Нет");

16) Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if( Math.Pow(x, 2) == y || Math.Pow(y, 2) == x){
    Console.WriteLine("Да");
} else Console.WriteLine("Нет");

// Дополнительная задача

Console.Write("Введите три числа массива: ");
int[] x = new int[3];
int sum = 0;

for (int i = 0; i < 3; i++)
{
    x[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 3; i++)
{
    if(x[i] >= 0){
        sum = sum + x[i];
    }
}
Console.Write(sum);

// Дополнительная задача по пересичению отрезков  

Console.WriteLine("Введите первые координаты: ");
int х1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторые координаты: ");
int х3 = Convert.ToInt32(Console.ReadLine());
int x4 = Convert.ToInt32(Console.ReadLine());
int max1, max2;

if(x1 < x3){
     max1 = x3;
    }
else max1 = x1;
if(x2 < x4){
    max2 = x4;
    }
else max2 = x2;