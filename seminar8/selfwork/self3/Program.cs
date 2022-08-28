/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

static void Main(string[] args)
        {
            int[,] mas = new int[5, 5];
            Random rnd = new Random();
            // заполняем массив случайными числами от 0 до 9
            for (int i = 0; i < 5; i++)
            {
 
                for (int j = 0; j < 5; j++)
                {
 
                    mas[i, j] = rnd.Next(10);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // определяем строку с минимальным  и максимальным элементом
            int min = mas[1, 1];
            int max = mas[1, 1];
            int minstr=0, maxstr=0;
            // определяем минимальную строку
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        minstr = i;
                    }
                    
                }
            }
            // определяем максимальную строку
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        maxstr = i;
                    }
                }
            }
 
            Console.WriteLine("Меняем местами строки {0} и {1} строку", minstr+1, maxstr+1);
            // перестановка строк
            int[] tempmas = new int[5];
            //Заносим минимальную строку во временный массив
            for (int i = minstr,j = 0, k=0; j < 5; j++,k++)
            {
 
                tempmas[k] = mas[i, j];
               
            }
            //Заменяем минимальную строку максимальной
            for (int j = 0; j < 5; j++)
            {
                mas[minstr, j] = mas[maxstr, j];
            }
             //Заменяем максимальную строку минимальной
            for (int j = 0; j < 5; j++)
            {
                mas[maxstr, j] = tempmas[j];
            }
 
            // вывод измененного массива
            Console.WriteLine("------------------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }