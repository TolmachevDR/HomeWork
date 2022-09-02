// Task 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int lenghtArray = 4;
int heightArray = 5;

double[,] array = new double[heightArray,lenghtArray]; 
FillArrayRandomDouble();
ShowArray();

void FillArrayRandomDouble(int min = -10, int max = 10)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min,max) + random.NextDouble();
        }
    }
}

void ShowArray()
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write ($"{array[i, j] : 0.0}\t");
        }

        Console.WriteLine();
    }
}