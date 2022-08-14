// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Clear();
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine()!);
string numberText = Convert.ToString(anyNumber);
int count = 0;
while (anyNumber > 0)
{
    count++;
    anyNumber /= 10;
}
Console.WriteLine("Количество цифр в вашем числе " + count);
Console.WriteLine("Количество цифр в вашем числе " + numberText.Length);