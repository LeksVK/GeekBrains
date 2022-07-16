Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

int ch = 0;
int ost = 0;

int Check(int a, int b) {

    if (a%b == 0 ) {
        return ch = 0; // кратно
    } else {
        ost = a%b;
        return ch = 1; // не кратно
    }
}

int n = Check(x, y);

if (n == 0) {
    Console.WriteLine("кратно");
} else
    Console.WriteLine($"не кратно, остаток {ost}");