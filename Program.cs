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
