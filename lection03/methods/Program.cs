// Методы в C# (Функции в программировании)

//Структура метода в общем виде:
//ВозвращаемыйТипДанных ([ТипДанных1 ИмяАргумента1, ТипДанных2 ИмяАргумента2, ...]);
//{
//  ТелоМетода
//  return Значение соответствующего возвращаемому типу данных;
//}

//Виды методов:
// Void-Методы, которые не принимают аргументы и не возвращают значение. 
//Используется для выводы сообщений на экран

// void Method1()
// {
//     System.Console.WriteLine("Сообщение");
// }
// Method1(); //вызов метода

//--------------------------------------------------------------

// Void-Методы, которые принимают аргументы, но не возвращают. 
//Используются для ...

// void Method2(string massage)
// {
//     System.Console.WriteLine(massage);
// }
// Method2("какой-то текст"); // при одном аргументе

// void Method21(string massage, int count) 
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(massage);
//         i++;
//     }
// }
// Method21(massage: "какой-то текст", 4); // 4 - сколько раз выдаст текст из massage

//----------------------------------------------------------------------------
// Методы, которые не принимают аргументы, но возвращают какие-то значения. 
//Используются для ...
 
//  int Method3 ()
//  {
//     return DateTime.Now.Year; //задаем возвращаемое значение
//  }
// int year = Method3(); //создаем новую переменную, в которую кладем то, что в методе
// System.Console.WriteLine(year); //вызываем новую переменную

//-----------------------------------------------------------------------------
// Методы, которые принимают аргументы и также возвращают какие-то значения. 
//Используются для ...

// string Method4(int count, string c) //будем строку "c" компоновать друг за другом "count" раз
// {
//     int i = 0;
//     string result = string.Empty; //возвращение пустой строки

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty"); //10 раз вызываем текст qwerty
// System.Console.WriteLine(res);

//------------------------------------------------------------------------------

// string Method5(int count, string c) 
// {
//     string result = string.Empty; //возвращение пустой строки

//     for (int i = 0; i < count; i++) //цикл со счетчиком вместо while 
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method5(1, "qwerty"); //10 раз вызываем текст qwerty
// // System.Console.WriteLine(res); //закомментировать при выводе таблицы чисел

// //добавление цикла в цикле для отображения таблицы умножения на экране
// {
//     for (int i = 2; i <= 10; i++)
//     {
//         for (int j = 2; j <= 10; j++)
//         {
//             System.Console.WriteLine($"{i} x {j} = {i * j}");//данный вид вывода называется интерполяцией строк
//         }

//         System.Console.WriteLine();
//     }
// }

//---------------------------------------------------------------------------

// //Задача в данном тексте заменить пробелы на тире, к на К, С на с.

// string text = "– Я думаю, – сказал князь, улыбаясь," 
//             + "– что, ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345
// // s[3] = r

// string ReplaceSymbols(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length; //показывает кол-во символов в строке
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = ReplaceSymbols(text, ' ', '-');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = ReplaceSymbols(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = ReplaceSymbols(newText, 'В', 'в');
// System.Console.WriteLine(newText);

//----------------------------------------------------
//Работа с массивами
//Задача 1. Упорядочить массив с наименьшего к наибольшему значению

int [] array = {1,3,5,4,2,7,6};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        //
        for (int j = i + 1; j < array.Length; j++)              //
        {                                                       //
            if(array[j] < array[minPosition]) minPosition = j;  //поиск максимального элемента
        }                                                       //
        //
        int temporary = array [i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);