// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

class Convert
{
    static void Main()
    {
        int num10 = 2; // число в десятичной системе исчисления
        int a = 0;  // a - остаток после % деления из которого формируется число в 
                    //    двоичной системе исчисления
        int i = 0;
        int[] b = new int[10]; // массив с помощью которого двоичное число позже 
                                 //будет выведено с конца для правильного отображения 
 
        while (num10 >= 1)
        {
            a = num10 % 2;
            b[i] = a;
            i++;
            num10 = num10 / 2;
            Console.Write(a);
        };
    }
 
}


string check(int n)
{
    string? result = "";
    while (n > 0)
    {
        int x = n % 2;
        result = Convert.ToString(x) + result;
        n /= 2;
    }
    return result;

}
Console.Write("Введите число, которое необходимо перевести в 2-ую систему: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(check(n));
