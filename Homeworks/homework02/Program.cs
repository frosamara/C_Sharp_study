//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void secondNumber(int num)
// {
//     int hund = num % 100;
//     int ed = num % 10;

//     Console.WriteLine($"{num} -> {(hund - ed) / 10}");
// } 
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// secondNumber(num);

//-----------------------------------------------------------------------------------------
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int thirdNumber(string threeDigitsNumber)
// {
//     Console.Write(threeDigitsNumber);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
//     int GetThirdNumb(int number)
//     {
//         while (number > 999)
//         {
//             number /= 10;
//         }
//         return number % 10;
//     }
//     bool CheckNumber(int number)
//     {
//         if (number < 100)
//         {
//             Console.WriteLine("not third number");
//             return false;
//         }
//         return true;
//     }
//         int number = thirdNumber("Input number ");
//         if (CheckNumber(number))
//         {
//             Console.WriteLine($"third number -> {GetThirdNumb(number)}");
//         }

//-----------------------------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Days(string text)
{
    System.Console.WriteLine(text);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int wDay)
{
    if (wDay > 5)
    {
        return true;
    }
    return false;
}

bool CheckWday(int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    System.Console.WriteLine("This number is not week's day");
    return false;
}

int wDay = Days("Input number of week's day");
if (CheckWday(wDay))
{
    if (IsWeekend(wDay))
    {
        System.Console.WriteLine("yes, it's weekend");
    }
    else
    {
        System.Console.WriteLine("no, it's working day");
    }
}