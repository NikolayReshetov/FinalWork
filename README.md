Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] > ["2", ":-)"]
["1234", "1567", "-2", "computer science"]  > ["-2"]
["Russia", "Denmark", "Kazan"] -> []

---
# Ввод данных
Внесение элементов массива строк в программе.

# Метод изменения массива
>1.Объявление временной переменной "temp" с типом данных string.

>2.Перебор всех строк в массиве:
>> 2.1. Если длина строки меньше либо равна 3 символам, то её значение добавляется к значению переменной "temp".

>>2.2. Объявление нового массива строк, которому присваиваются значения "temp" с разбивкой его содержания на элементы, обозначенные через пробел, с обрезанием пробелов.

# Вывод данных
**Вывод в консоль начального массива и нового  массива.**