// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2

int x;
int y;
int z;

int x2;
int y2;
int z2;

void inToPoint() {
    Console.WriteLine("Введите координату X для 1й точки:");
     x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y для 1й точки:");
     y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Z для 1й точки:");
     z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату X для 2й точки:");
     x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y для 2й точки:");
     y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Z для 2й точки:");
     z2 = Convert.ToInt32(Console.ReadLine());
}

double findS (int x,int x2 ,int y ,int y2 ,int z,int z2) {
    double result = Math.Sqrt((x2-x)*(x2-x)+(y2-y)*(y2-y)+(z2-z)*(z2-z));
    return result;
}

inToPoint();
double res = findS(x, x2, y, y2, z, z2);

Console.WriteLine(Math.Round(res, 2, MidpointRounding.ToZero));
