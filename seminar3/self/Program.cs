// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.Clear();
Console.WriteLine("Введите номер плоскости для определения диапазона координат точек: ");

void PrintplateNumber(int plateNumber)
{
string range = "Error";
if (plateNumber == 1)
    Console.Write("Ось x, ось y"); 
if (plateNumber == 2)
    Console.Write("Ось -x, ось y"); 
if (plateNumber == 3)
    Console.Write("Ось x, ось -y");
if (plateNumber == 4)
    Console.Write("Ось -x, ось -y");
}

int plateNumber = int.Parse(Console.ReadLine()!);
Console.Print.plateNumber(plateNumber);