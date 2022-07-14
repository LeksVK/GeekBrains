Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int e;

if (x >100 && x < 1000) {
    e = x%10;
    Console.WriteLine($" Последняя цифра введенного числа {e}");
} else {
    Console.WriteLine("Это не трехзначное число(");
}