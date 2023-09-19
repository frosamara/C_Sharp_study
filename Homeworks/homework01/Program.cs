// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
// а=5 b=7   -> max=7 min=5
// a=2 b=10  -> max=10 min=2
// a=-9 b=-2 -> max=-3 min=-9

//Console.WriteLine("Input number a");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input number b");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a<b)
//{
//     Console.WriteLine($"min -> {a}, max -> {b}");
//}
//else
//{
//    Console.WriteLine($"min -> {b}, max -> {a}");
//}

//------------------------------------------------------
// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

// Console.WriteLine("Input number a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number c");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a > b && a > c)
// {
//     Console.WriteLine($"max a -> {a}");
// }
// else
// if (b > c)    
// {
//     Console.WriteLine($"max b -> {b}");
// }
// else
// {
//     Console.WriteLine($"max c -> {c}");
// }

//-------------------------------------------------------
// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (/2 без остатка)
// 4 -> да
// -3 -> нет
// 7 -> да

// Console.WriteLine("Input number a");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// {
//    Console.WriteLine("yes");
// }
// else
// {
//    Console.WriteLine("No");
// }

//----------------------------------------------------------------------comand + / все выделенные строки комментирует
// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
//5 -> 2, 4
//8 -> 2, 4, 6,8

// Console.WriteLine("Write number n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     if (i % 2 == 0) 
//     {
//         Console.Write(i + " ");
//     }
// }

//все сделали через for, код работает. а через while где ошибка?
Console.WriteLine("Write number n: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < n)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine(i+ " ");
}
