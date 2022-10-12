﻿int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string[] FillArray(string[] array)
{
    string[] filledArray = array;
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = Convert.ToString(Console.ReadLine());
    }
    return filledArray;
}

int FindSizeArray(String[] array)
{
    int sizeElement = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeElement)
        {
            count++;
        }
    }
    return count;
}

string[] GetSortArray(string[] array, int sizeSortArray)
{
    string[] sortedArray = new string[sizeSortArray];
    int sizeElement = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeElement)
        {
            sortedArray[j] = array[i];
            j++;
        }
    }
    return sortedArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}