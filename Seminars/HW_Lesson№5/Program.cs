// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
void CreateArrayMethod(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArrayMethod(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}    

int EvenNumberMethod(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if(array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

int[] array = new int[8];
CreateArrayMethod(array);
PrintArrayMethod(array);
EvenNumberMethod(array);
Console.WriteLine($"Чётных чисел в массиве: {EvenNumberMethod(array)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void CreateArrayMethod(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
// }
// void PrintArrayMethod(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }    

// int SumEvenPosition(int[] array)
// {
//     int sum = 0;
//      for (int i = 1; i <= array.Length; i = i +2)
//      {
//         sum = sum + array[i];
//      }
//      return sum;
// }

// int[] array = new int[8];
// CreateArrayMethod(array);
// PrintArrayMethod(array);
// Console.WriteLine(SumEvenPosition(array));

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void CreateArrayMethod(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArrayMethod(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}    

int SearchMaxMethod(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int SearchMinMethod(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

int[] array = new int[8];
CreateArrayMethod(array);
PrintArrayMethod(array);
int max = SearchMaxMethod(array);
int min = SearchMinMethod(array);
int result = max - min;
Console.WriteLine($"Максимальное значение массива: {max}");
Console.WriteLine($"Минимальное значение массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {result}");