Console.WriteLine("Введите координату x для 1й точки:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для 1й точки:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для 2й точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для 2й точки:");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2-x)*(x2-x)+(y2-y)*(y2-y));

Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));
// AB = √(xb - xa)2 + (yb - ya)2