// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
 Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine()!);

int max = 0;

if (firstNumber > secondNumber) 
{
    max = firstNumber;
}
    else
{
    max = secondNumber;
}

if (max > thirdNumber)
{
    max = firstNumber;
}
    else
{
    max = thirdNumber;
}

Console.WriteLine($"Максимальное число = {max}");