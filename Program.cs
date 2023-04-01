/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] > ["2", ":-)"]
["1234", "1567", "-2", "computer science"]  > ["-2"]
["Russia", "Denmark", "Kazan"] -> []                  */

using System;
using static System.Console;

Clear();
string[] words1 = {"hello", "2", "world", ":-)"};
string[] words2 = {"1234", "1567", "-2", "computer science"};
string[] words3 = {"Russia", "Denmark", "Kazan"};

string[] NewMassive(string[] array){
    string temp = "";
    foreach (string el in array){
        if (el.Length <= 3) temp += el + " ";
        }
    string[] NewMassive = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return NewMassive;
}

WriteLine($" [{String.Join(", ", words1)}] > [{String.Join(", ", NewMassive(words1) ) }] ");
WriteLine($" [{String.Join(", ", words2)}] > [{String.Join(", ", NewMassive(words2) ) }] ");
WriteLine($" [{String.Join(", ", words3)}] > [{String.Join(", ", NewMassive(words3) ) }] ");