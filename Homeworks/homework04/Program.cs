// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Sqr(int number, int power)
// {
//     int newnumber = 1;
//     for (int i = 0; i < power; i++)
//     {
//         newnumber *= number;
//     }
//     return newnumber;
// }
// bool ValidatePower(int power)
// {
//     if (power < 0)
//     {
//         System.Console.WriteLine("power can't be low zero");
//         return false;
//     }
//     return true;
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input power: ");
// int power = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"number {number} raising to a power {power} is {Sqr(number, power)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumAllDigit(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Summ all numbers {number} = {SumAllDigit(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Prompt(string message)
// {
//     System.Console.WriteLine(massage);
//     string ReadInput = System.Console.ReadLine();
//     int result = int.Parse(ReadInput);
//     return result;
// }

// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//     int[] array = new int[Length];
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         System.Console.WriteLine($"{array[i]}, ");
//     }
//     System.Console.WriteLine($"{array[array.Length - 1]}");
//     System.Console.WriteLine("]");
// }

// int length = Prompt("Length of massive: ");
// int min = Prompt("min: ");
// int max = Prompt("max: ");
// int[] array = GenerateArray(length, min, max);
// PrintArray(array); 