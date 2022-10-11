// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 2*3 + 4*3  2*4 + 4*3
// 3*3 + 2*3  3*4 + 2*3

// Операция умножения двух матриц А и В определяется только для случая, когда ЧИСЛО СТОЛБЦОВ МАТРИЦЫ А РАВНО ЧИСЛУ СТРОК МАТРИЦЫ В.

if (firstM.GetLength(1) == secondM.GetLength(0)) {}

firstM[i,j] * secondM[i,j] 1 цикл
firstM[i,j] * secondM[j,i] 2 цикл
firstM[i,j] * secondM[i-1,j]
firstM[i,j] * secondM[i,j-1]

firstM[0,0] * secondM[0,0] 1 цикл +
firstM[0,1] * secondM[1,0] 2 цикл

firstM[1,0] * secondM[0,0] 3 цикл +
firstM[1,1] * secondM[1,0] 4 цикл

// сравниваем житое первой матрицы с итым второй матрицы, 
// если разные выводим сообщение не подходит
// если ок продолжаем

// новая матрица 
// элемент итое 
// элемент житое = элемент умнож на итое житое второй матрицы
// обновить счетчики

int m = 4; //кол-во строк 
int n = 4; // кол-во столбцов

int[,] array = new int[m, n];

int[,] GetMatrix (int m, int n) {

    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1);j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

int[,] DigitMatrix(int[,] array, int[,] secondArr) {

        for ( int i = 0 ; i < array.GetLength(0); i++) //строки
        {   
            for (int j = 0; j < array.GetLength(1); j++) //столбцы
            {
                
            }
        }

    return resultArray;
    
}

void PrintMatrix(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //столбцы
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1)-1) Console.Write(array[i,j] + ", ");
            else Console.Write(array[i,j] + "]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

int[,] secondMatrix = GetMatrix(m,n);
PrintMatrix(secondMatrix);
Console.WriteLine();

if(array.GetLength(1) == secondArr.GetLength(0)) {
    int[,] result = DigitMatrix(matrix, secondMatrix);
    Console.WriteLine("Результирующая матрица");
    PrintMatrix(result);
} else
Console.WriteLine("");

