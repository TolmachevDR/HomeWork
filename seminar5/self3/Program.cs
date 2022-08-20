// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int chislo, n, c = 0;
string s;
Console.WriteLine("Ввод массива целых чисел и проверка числа(входит ли это число в массив).");
Console.Write("Введите длину массива: ");
s = Console.ReadLine();
n = Convert.ToInt32(s);
Console.WriteLine("Вводите массив: ");
 
int[] x = new int[n];
    for (int i = 0; i < n; i++)
{
    Console.Write("-> ");
    x[i] = Convert.ToInt32(Console.ReadLine());
    c = x[i];
}

Console.Write("Введите число какое вы хотите проверть, находится ли он в массиве или нет: ");
chislo = Convert.ToInt32(Console.ReadLine());
    if (chislo != c)
{
    Console.WriteLine("Такого числа нет!!!");
    Console.ReadKey();
    return;
}

foreach (int a in x)
    if (a == chislo)
{
    Console.WriteLine("Да ваше число совпадает с числом из массива!");
    Console.WriteLine(c + " = " + chislo);
}