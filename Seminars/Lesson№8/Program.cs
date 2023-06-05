// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int InputNumber()
{
    int num = new Random().Next(5, 7);
    return num;
}
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ChangeRowsToColumns(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
                
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
            }
        }
        PrintArray(arr); // так можно, но метод теперь зависит от метода
    }
    else Console.WriteLine("No");;
}


int row = InputNumber(), colums = InputNumber();

int[,] array = new int[row, colums];
CraeteArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRowsToColumns(array);
//проверку if можно использовать тут, чтобы метод не зависил от метода 

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 5);
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
int DopleInNull(int[] arr, int[] newArr)
{
    int index = 0, count = 0;
    bool dup = true;
    for (int i = 0; i < arr.Length; i++)
    {
        dup = true;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                dup = false;
            }
        }
        if (dup)
        {
            newArr[index] = arr[i];
            index++;
            count++;
        }

    }
    return count;
}
void CreateArrayNoDopl(int[] arr, int[] newArr) //перезапись в массив с меньшим размером
{
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i];
    }
}
void CountArrayElement(int[] arr, int[] newArr)
{
    int count = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (newArr[i] == arr[j])
            {
                count++;
            }
        }
        Console.WriteLine($"Элемент {newArr[i]} был {count} раз");
    }
}
//1 5 9 0 8 8 2 8 9 5 
//1 5 9 0 8 2
int size = 10;
int[] array = new int[size];
int[] arrayN = new int[size];
CreateArray(array);
PrintArray(array);
int newSize = DopleInNull(array, arrayN);
int[] newArray = new int[newSize];
//PrintArray(arrayN);
CreateArrayNoDopl(arrayN, newArray);
//PrintArray(newArray);
CountArrayElement(array, newArray);


