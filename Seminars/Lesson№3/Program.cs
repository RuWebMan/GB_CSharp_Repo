// массивы - набор однотипных данных.

string f1 = "Bob";
string f2 = "Tom";
string f3 = "Ann";
string f4 = "Mary";
string f5 = "John";

string[] f = new string[5]; //создали массив строк, чтобы убрать лишние переменные 
//тип данных [] указание, что это массив, = новый массив типа стринг на 5 строк

string[] ff = new string[5] {"Bob", "Ann", "Tom", f4, f5};
// //еще один способ создания массива, вместо переменных подставляется значения

string[] fff = {"Bob", "Ann", f2, f4, f5};
//можно сразу внести данные в массив, без объявления нового.

 Console.WriteLine($"{ff[0]}");
 ff[0] = "Serg";
 Console.WriteLine($"{ff[0]}");
// // к любому элементу массива можно обратиться по его индексу, массив начинается с 0
// Console.WriteLine($"{ff[0]}");

// Console.WriteLine($"{ff.Length}"); //так можно узнать количество элементов массива

// for(int i = 0; i < ff.Length; i++){
//     Console.WriteLine($"{ff[i]}");
// }
// //с помощью цикла можно работать со всеми элементами массива 

// foreach (var item in ff) //var определяется во время компеляции
// {
//     Console.WriteLine($"foreach {item}");
// }
//можно использовать для проверки массива, поиска элемента, но менять зачения массива не получится

// Задача №17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.
// 2|1
// ___
// 3|4
// bool Coordin(int x){
//     if(x != 0){
//        return true;
//     }
//     return false;
// }

// Console.WriteLine("Введите координаты x y: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// if(Coordin(x) && Coordin(y)){
//     if(x > 0 && y > 0){
//         Console.WriteLine("1 четверть");
//     }
//     if(x < 0 && y < 0){
//         Console.WriteLine("3 четверть");
//     }
//     if(x < 0 && y > 0){
//         Console.WriteLine("2 четверть");
//     }
//     if(x > 0 && y < 0){
//         Console.WriteLine("4 четверть");
//     }
// }
// else Console.WriteLine("Укажите корректные координаты!");


// 18) Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат 
// точек в этой четверти (x и y).
// 2|1
// ___
// 3|4

// Console.WriteLine("Введите четверть координат: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x >= 1 && x <= 4)
// {
//     if(x == 1){
//       Console.WriteLine("X от 0 до + бесконечности, Y от 0 до + бесконечности");  
//     }
//     else if(x == 2){
//       Console.WriteLine("X от 0 до - бесконечности, Y от 0 до + бесконечности");  
//     }
//     else if(x == 3){
//       Console.WriteLine("X от 0 до - бесконечности, Y от 0 до - бесконечности");  
//     }
//     else if(x == 4){
//       Console.WriteLine("X от 0 до + бесконечности, Y от 0 до - бесконечности");  
//     }
// }
// else Console.WriteLine("Укажите корректную четверть!");

// 21) Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D 
// пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координаты для точки А: ");
// double ax = Convert.ToInt32(Console.ReadLine());
// double ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты для точки В: ");
// double bx = Convert.ToInt32(Console.ReadLine());
// double by = Convert.ToInt32(Console.ReadLine());

// double distans = Math.Sqrt(Math.Pow((ax-bx), 2)+Math.Pow((ay-by), 2));

// Console.WriteLine($"Расстояние между А и В = {Math.Round(distans, 3)}");

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.  
// 5 -> 1, 4, 9, 16, 25. 
// 2 -> 1,4

// Console.WriteLine("Введите число: ");
// double N = Convert.ToInt32(Console.ReadLine());
// double result = 1;
// int i = 1;
// Console.Write($"{N} =");
// while(i <= N){
//     result = Math.Pow(i, 2);
//     Console.Write($" {result} ");
//     i++;
// }

