# Задание: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Примеры:
### [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
### [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
### [“Russia”, “Denmark”, “Kazan”] → []
<br>
> Описание алгоритма решения задачи

1.  Получить от пользователя количество проверяемых строк
2.  Получить от пользователя строки в указанном ранее количестве, поместить их в массив
3.  Проверить есть ли в массиве строки с длинной, удовлетворяющей условию задачи: если нет, то закончить работу. Иначе:
4.  Создать массив для хранения строк, удовлетворяющих условия задачи
5.  Последовательно проверять длинну каждой строки массива.
6.  При условии, что длина строки менее 4 знаков сохранить ее в новый массив
7.  Вывести исходный массив на экран
8.  Вывести получившихся в результате решения задачи массив на экран

<br>
> Блок-схема алгоритма в файле diagram.png или diagram.json
<br>
