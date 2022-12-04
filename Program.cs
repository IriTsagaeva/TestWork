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

