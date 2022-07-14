Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
int s = y*y;

if(x == s)
{
    Console.Write($"Число {x} является квадратом числа {y}.");
} else { 
    Console.WriteLine($"Упс( Число {x} не квадрант числа {y}.");
}