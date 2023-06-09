//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void PrintNaturalNumbers(int num)
{
    if (num == 0)
        Console.WriteLine($"{num}.");
    else
    {
        Console.Write($"{num}, ");
        PrintNaturalNumbers(num - 1);
    }
}
Console.WriteLine(); // Добавляю Console.WriteLine для читабельности вывода в терминале.
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintNaturalNumbers(num);
Console.WriteLine();
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Первое решение с рекурсией.
/*
Console.WriteLine();
Console.Write("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int sum = SumNaturalNumbersInInterval(M, N);

int SumNaturalNumbersInInterval(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + SumNaturalNumbersInInterval(M + 1, N);
    }
}
Console.WriteLine(
    $"Cумма значений натуральных элементов в промежутке от {M} до {N} (включительно) равна -  {sum}"
);
Console.WriteLine();
*/

// Второе решение с циклом и проверкой "на дурака".

/*
Console.WriteLine();
Console.Write("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine();

if (M > N)
    (M, N) = (N, M);
for (int i = M; i <= N; i++)
{
    sum += i; // Либо прописываем 1 вместо i и получаем колличество натуральных элементов в промежутке от M до N.
}

Console.WriteLine(
    $"Cумма значений натуральных элементов в промежутке от {M} до {N} (включительно) равна -  {sum}"
);
Console.WriteLine();
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
Console.WriteLine(Ackermann(m, n));
