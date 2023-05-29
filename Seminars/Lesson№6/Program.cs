//двумерные массивы 

//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

// 1  2  3  4
// 5  6  7  8
// 9 10 11 12

// int[,] nums = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
// int[,] num = new int[3, 4];

// for (int i = 0; i < nums.GetLength(0); i++)
// {
//     for (int j = 0; j < nums.GetLength(1); j++)
//     {
//         Console.Write($"{nums[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void CraeteArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
// void ReversArray(int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         temp = arr[i];
//         arr[i] = arr[arr.Length - i - 1];
//         arr[arr.Length - i - 1] = temp;
//     }
// }
// int size = new Random().Next(5, 11);
// int[] array = new int[size];
// CraeteArray(array);
// PrintArray(array);
// ReversArray(array);
// PrintArray(array);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. 

// int InputNumber()
// {
//     Console.Write("Введите сторону треугольника: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// bool DoesItExist(int a, int b, int c)
// {
//     bool result = false;
//     if (a + b > c && a + c > b && b + c > a)
//     {
//         result = true;
//     }
//     return result;
// }
// int a = InputNumber();
// int b = InputNumber();
// int c = InputNumber();
// if (DoesItExist(a, b, c))
// {
//     Console.WriteLine("da");
// }
// else Console.WriteLine("net");

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
//45 -> 101101
//3  -> 11
//2  -> 10

int num;
Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
string rem = "";
while (num > 0)
{
    rem = (num % 2).ToString() + rem;
    num /= 2;
}
Console.WriteLine($"Бинарный формат для заданного номера {rem}");