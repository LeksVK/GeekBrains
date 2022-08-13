// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1, k1, b2, k2;

UserInput();
double[] result = ToFindCrossing(b1, k1, b2, k2);
Console.Write("Точка пересечения ");
PrintArray(result);
Console.WriteLine("");

void UserInput() {

        Console.WriteLine("Введите число b1:");
        b1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число k1:");
        k1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число b2:");
        b2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число k2:");
        k2 = Convert.ToInt32(Console.ReadLine());

}

double[] ToFindCrossing(int firstB, int firstK, int secondB, int secondK) {

    double a = (secondB - firstB);
    double b = (firstK - secondK);
    double x = Math.Round( a/b ,1);
    
    double y = k1 * x + b1;

    double[] point = new double[2];
    point[0] = x;
    point[1] = y;

    return point;
}

void PrintArray(double[] array) {
    int i = 0 ;
    while (i < array.Length) {
        Console.Write(array[i] + " ");
        i++;
    }
}