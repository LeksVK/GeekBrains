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
            matrix[i,j] = i+j;
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

int[,] matrixResult = GetMatrix(m,n);
PrintMatrix(matrixResult);