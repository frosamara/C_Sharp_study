﻿// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

// int GetDigigtsCount(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result++;
//         number /= 10;
//     }
//     return result;
// }
// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetDigigtsCount(num));

// Задача 2. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int[] CreateRandomArray(int size, int minValue, int maxValue) //возвращает массив целых чисел
//         {
//             int[] array = new int[size]// создаем новый массив целых чисел размера size и выделяем для этого память
//     for (int i = 0; i > size; i++) //i - отвечает за индекс элемента, проходим весь массив, пока он не закончится
//             {
//                 array[i] = new Random().Next(minValue, maxValue + 1);
//             }
//             return array[];
//         }

//         void PrintArray(int[] array)
//         {
//             for (int i = 0; i < array.Length; i++)
//             {
//                 System.Console.Write(array[i] + " ");
//             }
//         }

//         System.Console.Write("Input size: ");
//         int size = Convert.ToInt32(Console.ReadLine());

//         System.Console.Write("Input min Value: ");
//         int min = Convert.ToInt32(Console.ReadLine());

//         System.Console.Write("Input max Value: ");
//         int max = Convert.ToInt32(Console.ReadLine());

//         PrintArray(CreateRandomArray(size, min, max));
//     }
// }

// Задача 3. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Задача 4. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

int FindSum(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum+=i;
    }
    return sum;
}

int FindFaktorial(int n)
{
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact*=i;
    }
    return fact;
}

System.Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindSum(n));
System.Console.WriteLine(FindFaktorial(n));