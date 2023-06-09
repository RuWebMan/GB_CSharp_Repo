// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NatureNum(int num)
{
    if (num != 0)
    {
        NatureNum(num - 1);
        Console.Write($"{num} ");
    }
}
Console.Write("Введите число N: ");
int num = InputNumber();
NatureNum(num);

// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NatureNum(int start, int end)
{
    if (end == start)
        Console.Write($"{start} ");
    else
    {
        NatureNum(start, end - 1);
        Console.Write($"{end} ");
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
Console.Write("Введите число N: ");
int num2 = InputNumber();
if (num1 > num2)
    (num1, num2) = (num2, num1);
NatureNum(num1, num2);

// Задача 67: Напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int ReturnSumNum(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return ReturnSumNum(num / 10) + num % 10;
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
Console.WriteLine(ReturnSumNum(num1));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int ReturnDegreeNum(int num, int num1)
{
    if (num1 == 1)
    {
        return num;
    }
    else
    {
        return num * ReturnDegreeNum(num, num1 - 1);
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
Console.Write("Введите число N: ");
int num2 = InputNumber();
Console.WriteLine(ReturnDegreeNum(num1, num2));
