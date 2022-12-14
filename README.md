# TestWork

## Задание:

### Написать программу, которая из имеющегося массива строк сформируует массив из строк, длина которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

***Программа состоит из нескольких модулей:***

1. Функция string[] CreateNewStringArray (int size) возвращает одномерный массив размерности, указанной в вводном параметре size. Значения элементов массива вводятся пользователем с клавиатуры. Ниже представлено графическое изображение алгоритма выполнения этой функции.

    ![Алгоритм создания и ввода нового массива](/TestWork/images/CreateNewStringArray.jpg)

2. Функция int ReturnElementsCount (string inArray, int length) возвращает количество элементов строкового массива из параметра inArray, которые содержат количество символов, введенных в параметре length.Ниже представлено графическое изображение алгоритма выполнения этой функции.

    ![Алгоритм вычисления размерности массива-результата](/TestWork/images/ReturnElementsCount.JPG)

3. Функция void PrintArray (string[] inArray) предназначена для вывода строкового массива в консоль.Ниже представлено графическое изображение алгоритма выполнения этой функции.

    ![Алгоритм вывода массива](/TestWork/images/PrintArray.jpg)

4. Функция string[] GetArrayElementsWithLength (string inArray, int length) возвращает одномерный массив строк, состоящий из элементов массива из параметра inArray с длиной элементов меньшей или равной числу, указанному в параметре length. Ниже представлено графическое изображение алгоритма выполнения этой функции.

    ![Алгоритм получения массива с заданными параметрами](/TestWork/images/GetArrayElementsWithLength.jpg)



## Ниже представлена блок-схема работы программы, выполняющей задачу, описанную выше:

![Алгоритм выполнения задания](/TestWork/images/Main.jpg)
