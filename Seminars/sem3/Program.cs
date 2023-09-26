//Задача 1. Напишите программу, которая принимает на вход координаты точки (X иY), причом X, Y не равны 0.
//Выдает номер четверти, в которой находится точка

// int FindQuarter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }

// System.Console.WriteLine("input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindQuarter(x,y));

//Задача 2. Напишите программу, которая на вход принимает число n и выдает таблицу квадратов
//от 1 до n

// void QuadTable(int n)
// {
//     int current = 1;
//     while (current < n)
//     {
//         System.Console.Write(current * current + ",");
//         current++;
//     }
// }
// System.Console.WriteLine("input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// QuadTable(n);

//Задача 3. Написать программу, которая на вход принимает корродинаты двух точек и находит расстояние между ними в 2D пространстве.
//(теорема Пифагора сумма квадратов катето в = квадрату гипотенузы)

// double DistanceCoord (double xa, double ya, double xb, double yb)
// {
//     return Math.Sqrt(Math.Pow (xb - xa, 2) + Math.Pow (yb - ya, 2));
// }

// System.Console.WriteLine("input coordinates: ");
// System.Console.WriteLine("A (x): ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("A (y): ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("B (x): ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("B (y): ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine($"A ({xa}, {ya}); B ({xb}, {yb}) -> {Math.Round(DistanceCoord(xa, ya, xb, yb), 2)}");

//Задача 4. Напишите программу, которая по заданному номеру четверти показывает диапозон возможных координат точек в этой четверти (x,y)
// void Coordinat (int quarter)
// {
//     if (quarter == 1)
//     System.Console.WriteLine("x > 0, y > 0");

//     else if (quarter == 2)
//     {
//         System.Console.WriteLine("x < 0, y > 0");
//     }
//     else if (quarter == 3)
//     {
//         System.Console.WriteLine("x < 0, y < 0");
//     }
//     else if (quarter == 4)
//     {
//         System.Console.WriteLine("x > 0, y < 0");
//     }
//     else
//     {
//         System.Console.WriteLine("Error");
//     }
// }

// System.Console.WriteLine("input quarter: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Coordinat(q);
