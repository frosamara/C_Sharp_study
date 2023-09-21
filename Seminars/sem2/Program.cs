// void CheckMultiplicity(int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         Console.WritLine($"{num1},{num2} -> крастно");
//     }
//     else
//     {
//         Console.WritLine($"{num1},{num2} -> некратно, остаток {num1 % num2}");
//     }
// }
// Console.WritLine("Input first number: ");
// int n1 = Convert.ToInt32(Console.REadLine());
// Console.WritLine("Input second number: ");
// int n2 = Convert.ToInt32(Console.REadLine());

// CheckMultiplicity(n1, n2);
//----------------------------------------------------
// Задача 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int BiggestDigit(int num)//метод возвращает бОльшую цифру
// {
//     int ed = num % 10; //находим вторую цифру в числе
//     int dec = num / 10; //находим первую цифру в числе
//     if(ed > dec)
//     {
//         return ed;
//     }
//     else
//     {
//         return dec;
//     }
// }
// int num = new Random().Next(10, 99 + 1);//вызываем конструктор, генерируем случайное двоичное число в заданном диапазоне, вызываем метод Next 
// Console.WriteLine(num);
// // int result = BiggestDigit(num);
// // Console.WritLine(result);

// Console.WriteLine(BiggestDigit(num));
//------------------------------------------------------------
// Задача 3. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

// void exampleMethod(int num)
// {
//     int hund = num / 100;
//     int ed = num % 10;
//     Console.WriteLine($"{num} -> {hund * 10 + ed}");
// } 

// int num = new Random().Next(100, 1000);
// exampleMethod(num);
//-----------------------------------------------------------
// Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14  ->  нет
//46  ->  нет
//161 ->  да

bool CheckMultiplicity(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {num1} -> {CheckMultiplicity(num1)}");