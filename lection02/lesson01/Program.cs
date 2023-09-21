// Работа с функциями

// Задача. Найти максимум из 9 чисел
// первый способ без использования функций
// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Console.WriteLine(max);
//-------------------------------------------
//второй вариант с использованием функции
// int max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 2003;
// int c3 = 303;

// 1ый вариант вывода функции
// int max1 = max(a1, b1, c1);
// int max2 = max(a2, b2, c2);
// int max3 = max(a3, b3, c3);
// int res = max(max1, max2, max3);

// 2ой вариант вывода функции
// int res = max(max(a1, b1, c1), max(a2, b2, c2), max(a3, b3, c3));
// Console.WriteLine(res);
//-----------------------------------------

// Работа с массивами
// int max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //              0   1   2   3   4   5   6   7   8
// int [] array = {15, 21, 39, 12, 23, 33, 13, 24, 35};
// int res = max(
//     max(array[0], array[1], array[2]),
//     max(array[3], array[4], array[5]),
//     max(array[6], array[7], array[8])
// );  
// Console.WriteLine(res);
//---------------------------------------------------

// int [] array = {1,2,3,4,5,6,7,8};

// int n = array.Length; //определение длины массива
// int find = 4;
// int index = 0;

// while (index < n)
//     {
//         if(array[index] == find)
//         {
//             Console.WriteLine(index);
//             break;
//         }
//         index++; // index = index + 1
//     }

//------------------------------------------------------------------------

// void FillArray(int[] collection) //void - метод, который не возвращает значение
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[10]; //создание нового массива, состоящего из 10 элементов (изначально заполненного нулями)

// FillArray(array); //заполнение массива случайными числами
// PrintArray(array); //печать массива

//--------------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray(int[] collection) //void - метод, который не возвращает значение
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
            int count = col.Length;
            int position = 0;
            while (position < count)
            {
                Console.WriteLine(col[position]);
                position++;
            }
        }

        int indexof(int[] collection, int find)
        {
            int count = collection.Length;
            int index = 0;
            int position = -1;

            while (index < count)
            {
                if (collection[index] == find)
                {
                    position = index;
                    break;
                }
                index++;
            }
            return position;
        }
        int[] array = new int[10]; //создание нового массива, состоящего из 10 элементов (изначально заполненного нулями)
        FillArray(array); //заполнение массива случайными числами
        PrintArray(array); //печать массива
        Console.WriteLine();
        
        int pos = indexof(array, 4);
        Console.WriteLine(pos);
    }
}