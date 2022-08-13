Console.Clear();
Console.WriteLine("Введите координату точки 1 по оси х: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки 1 по оси y: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки 2 по оси x: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки 2 по оси y: ");
double y2 = double.Parse(Console.ReadLine()!);
double result = 0;
{
double dx = Math.Pow(x1-x2,2);
double dy = Math.Pow(y1-y2,2);
result = Math.Sqrt(dx+dy);
return result;
}
Console.Write($"Расстояние между точками: + {result}");