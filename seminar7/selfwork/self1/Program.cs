// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    int[,] array = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
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

    int[,] array = GetArray(3, 4, -10, 10);

    Console.WriteLine(
        GetStringFromArray(array)
        );