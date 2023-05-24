
using System.Security.AccessControl;
using System;
// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.Например, в массиве 
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

/*
void CreateArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
}

int NegativSum (int [] array)
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0 )
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int PositivSum (int [] array)
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 )
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int [] arr = new int [12];
CreateArray(arr);
Console.WriteLine($"sum negativ is {NegativSum(arr)}");
Console.WriteLine($"sum positiv is {PositivSum(arr)}");
*/

// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

/*
void CreateArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void Convert (int [] array)
{
    for(int i = 0; i < array.Length; i++ )
    {
        array[i] *= -1;
    }
}

int [] arr = new int[12];
CreateArray(arr);
PrintArray(arr);
Convert(arr);
PrintArray(arr);
*/

// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

/*
void CreateArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void SearchNumber (int [] array, int num)
{
    bool numSearch = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num || array[i]== -num)
        {
            numSearch = true;
            //Console.WriteLine("Заданное число присутствует в массиве");
            break;
        }
        
    }
   if(numSearch) Console.WriteLine($"Число {num} присутствует в массиве.");
   else Console.WriteLine($"Число {num} не присутствует в массиве.");
}


int [] arr = new int[10];
CreateArray(arr);
PrintArray(arr);
SearchNumber(arr, 5);
*/

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5

/*
void CreateArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
    }
}


int SearchElement(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count ++;
        }
    }
    return count;
}

int [] arr = new int[123];
CreateArray(arr);
System.Console.WriteLine($"{SearchElement(arr)} элементов");
*/

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
//  [6 7 3 6] -> 36 21

/*
int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void MultArray(int[] arr)
{
    int mult = 1;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if(i != size -1)
        {
        mult = arr[i] * arr[size - 1];
        size--;
        Console.Write($"{mult} ");
        }
        else Console.Write($"{arr[i]} ");
    }
}
int size = InputNumber();
int[] array = new int[size];
CreateArray(array);
PrintArray(array);
MultArray(array);
*/

//Бонусная задача.
//Создать массив из 10 элементов. Удалить дубликаты. 

/*
void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void DeleteDuplicate(int[] array)
{
    for (int x = 0; x < array.Length; x++)
    {
        for (int z = 0; z < array.Length; z++)
        {
            if (x != z && array[x] == array[z]) array[z] = -1;
        }
        if (array[x] != -1) Console.Write($"{array[x]} ");
    }
}
//1 5 9 0 8 8 2 8 9 5 
//1 5 9 0 8 2
int size = 10;
int[] array = new int[size];
CreateArray(array);
PrintArray(array);
DeleteDuplicate(array);
*/

