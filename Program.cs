string[] CreateNewStringArray(int inSize)
{
    string[] resultArray = new string[inSize];
    for (int i = 0; i < inSize; i++)
    {
        Console.WriteLine($"Введите значение элемента {i + 1}");
        resultArray[i] = Console.ReadLine();
    }
    return resultArray;
}

void PrintArray(string[] inArray)
{
    Console.Write("[ ");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"\"{inArray[i]}\" ");
    }
    Console.WriteLine("]");
}


int ReturnElementsCount(string[] inArray, int length)
{
    int count = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (inArray[i].Length <= length)
        {
            count++;
        }
    }
    return count;
}


string[] GetArrayElementsWithLength(string[] inArray, int length)
{
    int size = ReturnElementsCount(inArray, length);
    string[] resultArray = new string[size];
    for (int i = 0, j = 0; i < inArray.GetLength(0); i++)
    {
        if (inArray[i].Length <= length)
        {
            resultArray[j] = inArray[i];
            j++;
        }
    }
    return resultArray;
}

Console.Clear();
Console.WriteLine("Введите количество элементов Вашего массива");
bool sizeIsEntered = Int32.TryParse(Console.ReadLine(), out int size);
if (sizeIsEntered && size > 0)
{
    string[] myArray = CreateNewStringArray(size);
    Console.WriteLine("Ваш массив:");
    PrintArray(myArray);
    Console.WriteLine("Пожалуйста, введите количество символов в искомых элементах");
    bool lengthIsEntered = Int32.TryParse(Console.ReadLine(), out int myLength);
    if (lengthIsEntered && myLength > 0)
    {
        int elementsCount = ReturnElementsCount(myArray, myLength);
        if (elementsCount > 0)
        {
            string[] resultArray = GetArrayElementsWithLength(myArray, myLength);
            Console.WriteLine("Элементы, удовлетворяющие введенным параметрам:");
            PrintArray(resultArray);
        }
        else
        {
            Console.WriteLine("Элементов с заданными параметрами в этом массиве нет!");
        }
    }
    else
    {
        Console.WriteLine("Пожалуйста, введите корректное количество символов!!!");
    }
}
else
{
    Console.WriteLine("Пожалуйста, введите корректную размерность массива!");
}

