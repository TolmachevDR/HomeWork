/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */


int a = int.Parse(Console.ReadLine());
            int summ = 0;
            while (a > 0)
            {
                summ = summ + a % 10;
                a = a /10 ;
            }
Console.WriteLine(summ);