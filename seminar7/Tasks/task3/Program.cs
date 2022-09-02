//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = 2;
int columns = 3;
int [,] numbers = new int [rows,columns];
FillArray (numbers);
PrintArray (numbers);
double [] sum = new double [columns] ;
for (int i = 0; i < numbers.GetLength (1); i ++)
{
    for (int j = 0; j < numbers.GetLength(0); j ++)
    { 
        sum [i] = sum [i] + numbers [j,i];
    }
    double average = sum [i] / rows;
    double result = Math.Round (average, 2);
    Console.WriteLine (result);
}

void FillArray (int [,] array)
{
    for (int i =0; i < array.GetLength (0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++ )
        {
            array [i,j] = new Random().Next (0,9);
        }
    }
}
void PrintArray (int [,] array)
{
    for (int i =0; i < array.GetLength (0); i ++)
    {
        for (int j = 0; j < array.GetLength (1); j ++ )
        {
            Console.Write (array [i,j] + " ");
        }
        Console.WriteLine();
    }
      Console.WriteLine();  
}