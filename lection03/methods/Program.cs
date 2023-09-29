﻿// Методы в C# (Функции в программировании)

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

void Method21(string massage, int count) 
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(massage);
        i++;
    }
}
Method21(massage: "какой-то текст", 4); // 4 - сколько раз выдаст текст из massage

// Методы, которые не принимают аргументы, но возвращают какие-то значения. 
//Используются для ...

// Методы, которые принимают аргументы и также возвращают какие-то значения. 
//Используются для ...