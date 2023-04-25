Домашняя работа по семинару №2

Задача 10: Напишите программу, которая принимает на вход трёхзначное
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = (num % 100) / 10;

Console.WriteLine(result);


Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


Console.Write("Введите  число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num} -> ");

if (num < 0) num *= -1;
if (num <= 99 && num >= -99) Console.Write("третьей цифры нет");
else Console.Write(SecondNum(num));

int SecondNum(int num)
{
    while (num >= 999) num /= 10;
    return num % 10;
}


Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 5 && num != 0)
{
    Console.WriteLine($"{num} это рабочий день недели.");
}
else if(num == 6 || num == 7)
{
    Console.WriteLine($"{num} это выходной!");
}
else
{
    Console.WriteLine($"Гражданин, {num} это не день недели.");
}
