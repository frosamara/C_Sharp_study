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

//второй вариант с использованием функции
int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 2003;
int c3 = 303;

// 1ый вариант вывода функции
// int max1 = max(a1, b1, c1);
// int max2 = max(a2, b2, c2);
// int max3 = max(a3, b3, c3);
// int res = max(max1, max2, max3);

// 2ой вариант вывода функции
int res = max(max(a1, b1, c1), max(a2, b2, c2), max(a3, b3, c3));
Console.WriteLine(res);