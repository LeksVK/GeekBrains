// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

Console.WriteLine("Введите позицию по горизонтали:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию по вертикали:");
int nextNum = Convert.ToInt32(Console.ReadLine());

bool FindInMatrix (int[,] matrix,int num, int nextNum) {
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int result = 0;

    if(num <= row && nextNum <= column) {
        
            result = matrix[num-1, nextNum-1];
            return true;

    } else  return false;
}


int[,] matrixResult = GetMatrix(m,n);
PrintMatrix(matrixResult);

bool res = FindInMatrix(matrixResult, num, nextNum);

if(res == false ) {
    Console.WriteLine("такого числа в массиве нет");
} else Console.WriteLine("такое число в массиве есть");
