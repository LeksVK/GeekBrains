Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = -x;


while (y <= x) {
    Console.WriteLine(y);
    y++;
}