/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

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

int FindSummmainDiagonal(int[,] array)
{
    int sum = 0;
    int minLen;
    if (array.GetLength(0) > array.GetLength(1))
        minLen = array.GetLength(1);
    else
        minLen = array.GetLength(0);
    for (int i = 0; i < minLen; i++)
    {
        sum += array[i, i];
    }
}