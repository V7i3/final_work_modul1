# Итоговая проверочная работа по модулю 1

### _Задача:_ 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

#### _Примеры:_
- ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
- ["1234", "1567", "-2", "computer science"] -> [ "-2" ]
- ["Russia", "Denmark", "Kazan"] -> [ ]

### Алгоритм решения:
1. Создать массив равный по длине с исходным. 
2. Затем в цикле перебирать элементы исходного массива. Если количество символов элемента массива <= 3, тогда элемент записывать в массив, созданный на шаге 1.
3. После заполнения массива, убрать пустые ячейки.
