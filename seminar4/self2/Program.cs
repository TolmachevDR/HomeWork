// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int size = 8;
// int[] array = new int[size]; arr = ([0, 1] * n);

int[] RandomNumbersArray(int size)
{
    int[] numbersArray = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        numbersArray[i] = rnd.Next(2);
    } 
    return numbersArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int size = 8;
int[] array = RandomNumbersArray(size);
PrintArray(array);
