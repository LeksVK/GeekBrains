// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];

double[] FullArray(double[] array) {

    int n = array.Length;
    double[] newArray = array;
    int i =0;

    Random rnd = new Random();

    while (i <= n-1) {
        double x = rnd.NextDouble();
        x = Math.Round(x, 2);
        newArray[i] = x;
        i++;
    }

    return newArray;
}

double FindSumMaxMin(double[] array) {
    double res = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) {
            max = array[i];
        } 

        if (array[i] < min) {
            min = array[i];
        }
    }

    //  max = Math.Round(max,2);
    //  min = Math.Round(min,2);
    res = max - min;
    res = Math.Round(res,2);

    return res;
}


void PrintArray(double[] array) {
    int i = 0 ;
    while (i < array.Length) {
        Console.Write(array[i] + " ");
        i++;
    }
}

FullArray(array);
PrintArray(array);
double result = FindSumMaxMin(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным элементом массива и минимальным = {result}");