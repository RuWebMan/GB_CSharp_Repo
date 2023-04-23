// int [] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// Console.WriteLine(array[2]);

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    // int count = col.Length;
    // int position = 0;
    // while (position < count)
    // {
    //     Console.WriteLine(col[position]);
    //     position++;
    // } 

// второй вариант написания
    for (int i = 0; i < col.Length; i++)
    {
        Console.WriteLine(col[i]);
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}


int [] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);



