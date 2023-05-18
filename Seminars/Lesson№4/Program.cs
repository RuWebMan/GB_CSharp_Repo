//методы и функции

/*
void SayLang(string name){
    Console.WriteLine($"привет, {name}");
}
SayLang("python");
SayLang("c#");
string lang = "c++";
SayLang(lang);

int SayMax(int num1, int num2){
    if(num1 > num2) return num1;
    else return num2;
}
//один из вариантов вывода
Console.WriteLine(SayMax(3, 5));
//второй вариант вывода
int num = SayMax(4, 7);
Console.WriteLine(num);
//и еще один вариант
int x = 9, y = 6, num1 = SayMax(x, y);
Console.WriteLine(num1);
*/

// Практика

// Задача №24
/*
Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

/*
int SumNumber(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result += i;
    }
    return result;
}
Console.WriteLine("Vvedite: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumber(num));
*/

// Задача 26
/*
 Напишите программу, которая принимает на вход число и выдаёт
 количество цифр в числе.
 456 -> 3
 78 -> 2
 89126 -> 5
 */

/*
int SizeArray(int size)
{
    int count = 0;
    while (size > 0)
    {
        size /= 10;
        count++;
    }
    return count;
}
Console.WriteLine("Vvedite: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SizeArray(num1));
*/

// Задача №28
/*
 Напишите программу, которая принимает на вход число N и выдаёт
 произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

/*
int MultNumber(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine("Vvedite: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MultNumber(num3));
*/

// Задача №30
/* 
Напишите программу, которая выводит массив из 8 элементов, 
 заполненный нулями и единицами в случайном порядке.
 [1,0,1,1,0,1,0,0]
 */

/*
void RandomArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2); //(от 0 до N-1)
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RandomArr(array);
PrintArray(array);
*/