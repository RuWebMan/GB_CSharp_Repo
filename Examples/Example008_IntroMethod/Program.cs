//Стихийный метод.

// int a1 = 29, b1 = 8, c1 = 34;
// int a2 = 81, b2 = 221, c2 = 43;
// int a3 = 65, b3 = 837, c3 = 42;

// int max = a1;

// if(max < b1) max = b1;
// if(max < c1) max = c1;

// if(max < a2) max = a2;
// if(max < b2) max = b2;
// if(max < c2) max = c2;

// if(max < a3) max = a3;
// if(max < b3) max = b3;
// if(max < c3) max = c3;

// Console.WriteLine($"max = {max}");

// Функциональный метод

// int a1 = 29;
// int b1 = 8; 
// int c1 = 34;
// int a2 = 81; 
// int b2 = 21;
// int c2 = 43;
// int a3 = 65;
// int b3 = 437; 
// int c3 = 962;

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Корткий вариант записи результирующего кода:

// int max = Max(
//               Max(a1, b1, c1),
//               Max(a2, b2, c2),
//               Max(a3, b3, c3)
//               );

// Console.WriteLine(max);



