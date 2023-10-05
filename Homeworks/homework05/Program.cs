// Задача 1. Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: 
// {100, 102, 105, 166, 283, 764, 300, 499, 133}.
// Аргументы, передаваемые в метод/функцию:
// '124, 378, 593, 821, 456'

// На выходе:
// Массив:
// 124 378 593 821 456 
// Количество четных элементов: 3

// using System;

// public class Answer
// {
//     public static int CountEvenElements(int[] array)
//     {
//         int count = 0;
//         foreach (int number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }

//     public static void PrintArray(int[] array)
//     {
//         foreach (int number in array)
//         {
//             Console.Write($"{number}\t");
//         }
//         Console.WriteLine();
//     }

//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//             array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         Console.WriteLine("Массив:");
//         PrintArray(array);
//         int evenCount = CountEvenElements(array);
//         Console.WriteLine($"Количество четных элементов: {evenCount}");
//     }
// }

//------------------------------------------------------------------------------------------------
// Задача 2. Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// Аргументы, передаваемые в метод/функцию:
// '18, 76, 11'
// На выходе:
// 18  76  11  
// Сумма нечетных элементов: 76

// using System;

// public class Answer
// {
//     public static int SumOddElements(int[] array)
//     {
//         int sum = 0;
//         for (int i = 1; i < array.Length; i = i + 2)
//         {
//             sum += array[i];
//         }
//         return sum;
//     }

//     public static void PrintArray(int[] array)
//     {
//         foreach (int number in array)
//         {
//             Console.Write($"{number}\t");
//         }
//         Console.WriteLine();
//     }

//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем массив по умолчанию
//             array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         PrintArray(array);
//         int sumOdd = SumOddElements(array);
//         Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
//     }
// }
//-------------------------------------------------------------------------
// Задача 3. Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
// Аргументы, передаваемые в метод/функцию:
// '3.17, 8.94, 2.36, 5.72, 0.85'
// На выходе:
// Массив:
// 3.17    8.94    2.36    5.72    0.85    
// Разность между максимальным и минимальным элементом = 8.09

using System;

public class Answer
{
    public static double FindMax(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    public static double FindMin(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {
        return FindMax(array) - FindMin(array);
    }

    public static void PrintArray(double[] array)
    {
        foreach (double number in array)
        {
            Console.Write($"{number:f2}\t");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}
