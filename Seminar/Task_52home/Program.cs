// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//int[,] arrayTest = new int[3, 4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

int m = 3;
int n = 4;

int[,] array = new int[m, n];

int[,] GetMatrix (int m, int n) {

    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1);j++)
        {
            matrix[i,j] = rnd.Next(0, 100);
        }
    }

    return matrix;
}

double[] GetAverColumn(int[,] array) {

    double[] averCol = new double[array.GetLength(1)];
    int row = array.GetLength(0);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;j < array.GetLength(1);j++)
        {
            averCol[j] = averCol[j] + array[i,j]; 
        }
    }

    for (int i = 0; i < averCol.Length; i++)
    {
        averCol[i] = Math.Round(averCol[i] / row, 1);
    }

    return averCol;
}

void PrintMatrix(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //столбцы
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1)-1) Console.Write(array[i,j] + ",");
            else Console.Write(array[i,j] + "]");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array) {
    int i = 0 ;
    while (i < array.Length) {
        Console.Write(array[i] + " ");
        i++;
    }
}


int[,] matrixResult = GetMatrix(m,n);
PrintMatrix(matrixResult);
//double[] result = GetAverColumn(arrayTest);
double[] result = GetAverColumn(matrixResult);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray(result);
Console.WriteLine();