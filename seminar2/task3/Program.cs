//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введи число, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день недели выходной");
}
else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Такого дня недели нет");
}
else Console.WriteLine("Этот день недели не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);