/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */

int[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    int[,] array = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minRandomValue, maxRandomValue + 1);
        }
        return array;
    }

    string GetStringFromArray(int[,] array)
    for (int i= 0; i < array.GetLength(0); i++)
    {
        string result = string.Empty;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j] + " ";
        }
        result += "\n";
    }
}

bool SwapStrings(int[,] array)
{
    if (array.GetLength(0)<=1)
    return false;
    int lastRow = array.GetLength(0) -1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
    int tmp = array[0, i];
    array[0, i] = array[lastRow, i];
    array[lastRow, i] = tmp;
    }
    return true;
}

int rows = 4;
int columns = 4;
int minValue = -10;
int maxValue = 10;
int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.Write($"исходный массив [{rows}*{columns}], ");
Console.WriteLine($)